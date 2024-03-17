using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CountNPV
{
    public class NpvVM : INotifyPropertyChanged
    {
        private string year = "2050";
        private string discount = "0.2";
        private double npv;
        public string Year { get { return year; } set { year = value;  } }

        public string Discount { 
            get 
            {
                return discount; 
            } set { discount = value; } }
        public double NPV { get { return Math.Round(npv, 2); } private set { npv = value;  } }

        private Command countNPV;
        public Command CountNPV 
        {
            get
            {
                return countNPV ??
                    (countNPV = new Command(obj =>
                    {
                        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                        if (double.TryParse(Discount, NumberStyles.AllowDecimalPoint, formatter, out double result))
                        {
                            if (result < 0)
                            {
                                MessageBox.Show("Ставка дисконтирования указана в неверном формате");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ставка дисконтирования указана в неверном формате");
                            return;
                        }
                        if (Int32.TryParse(Year.ToString(), out int year))
                        {
                            if (year < 2020 || year > 2050)
                            {
                                MessageBox.Show("Год указан неверно, возможные значения: 2020 - 2050");
                                return;
                            }
                        }
                        
                        NPV = NpvModel.CountNPV(Double.Parse(Discount, NumberStyles.AllowDecimalPoint, formatter), Int32.Parse(Year));
                        OnPropertyChanged("NPV");
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
