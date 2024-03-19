using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace CountNPV
{
    internal class NpvModel
    {
        public double CountNPV(double discount, int year)
        {
            string filename = "data.xlsx";
            string path = Path.GetFullPath(filename);

            DataSet data = new DataSet();
            OleDbConnectionStringBuilder csbuilder = new OleDbConnectionStringBuilder();
            csbuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            csbuilder.DataSource = path;
            csbuilder.Add("Extended Properties", "Excel 12.0 Xml;"); 
            string selectSql = @"SELECT * FROM [справочник$]";
            using (OleDbConnection connection = new OleDbConnection(csbuilder.ConnectionString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connection))
                { 
                    adapter.Fill(data);
                }
            }
            var valueRows = data.Tables[0].Rows;
            int i = 0;
            double npv = 0;
            while (Convert.ToInt32(valueRows[i][0]) < year)
            {
                int cf = Convert.ToInt32(valueRows[i][1]) - Convert.ToInt32(valueRows[i][2]);
                npv += (double)cf * (1 / Math.Pow((1.0 + discount), i + 1));
                i++;
            }
            int cf_last = Convert.ToInt32(valueRows[i][1]) - Convert.ToInt32(valueRows[i][2]);
            npv += (double)cf_last * (1 / Math.Pow((1.0 + discount), i + 1));

            return npv;
        }
    }
}
