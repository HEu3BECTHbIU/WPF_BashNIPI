using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace CountNPV
{
    public class NpvVM : INotifyPropertyChanged
    {
        private string year = "2050";
        private string discount = "0.2";
        private double npv;
        private string errormessage = string.Empty;
        private NpvModel model;
        public string Year
        { 
            get
            { 
                return year;
            } set
            {
                year = value;
                OnPropertyChanged("Year");
            } 
        }
        public string Discount
        { 
            get 
            {
                return discount; 
            } 
            set
            {
                discount = value;
                OnPropertyChanged("Discount");
            } 
        }
        public string ErrorMessage
        {
            get 
            {
                return errormessage;
            }
            set 
            {
                errormessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }
        public double NPV
        { 
            get
            { 
                return Math.Round(npv, 2);
            }
            private set 
            {
                npv = value;
            } 
        }

        public NpvVM()
        {
            model = new NpvModel();
        }
        private Command countNPV;
        public Command CountNPV 
        {
            get
            {
                return countNPV ??
                    (countNPV = new Command(obj =>
                    {
                        ErrorMessage = string.Empty;
                        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                        if (double.TryParse(Discount, NumberStyles.AllowDecimalPoint, formatter, out double result))
                        {
                            if (result < 0) 
                            {
                                ErrorMessage += "Неверная ставка дисконтирования\n";
                                Discount = "0.2";
                            }
                        }
                        else
                        {
                            ErrorMessage += "Неверная ставка дисконтирования\n";
                            Discount = "0.2";
                        }
                        if (Int32.TryParse(Year.ToString(), out int year))
                        {
                            if (year < 2020 || year > 2050)
                            {
                                ErrorMessage += "Год указан неверно, возможные значения: 2020 - 2050";
                                Year = "2050";
                                return;
                            }
                        }
                        else
                        {
                            ErrorMessage += "Год указан неверно, возможные значения: 2020 - 2050";
                            Year = "2050";
                            return;
                        }
                        if (ErrorMessage == string.Empty)
                        {
                            NPV = model.CountNPV(double.Parse(Discount,NumberStyles.AllowDecimalPoint, formatter), Int32.Parse(Year));
                            OnPropertyChanged("NPV");
                        }
                    }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
