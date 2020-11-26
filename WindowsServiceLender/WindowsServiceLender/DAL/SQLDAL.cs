using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using WindowsServiceLender.Models;
using WindowsServiceLender.DocOperations;
using System.Data;

namespace WindowsServiceLender.DAL
{
    public class SQLDAL
    {
        public List<DocValues> MyConnection()
        {
            // string constr = "Data Source=SYS73;Initial Catalog=ShyDatabase;User ID=sa;Password=sa123$";
            //  SqlConnection con = new SqlConnection(constr);
            //  con.Open();

            //  string sqlquery = "SELECT *FROM NextGenPPP WHERE ID=1";
            //  SqlCommand cmd = new SqlCommand(sqlquery, con);

            //  SqlDataReader reader = cmd.ExecuteReader();
            //   reader.Read();
            List<DocValues> values = new List<DocValues>();

            values.Add(new DocValues { key = "wordcontrolname", value = "Zed" });
            values.Add(new DocValues { key = "wordcontrolage", value = "22" });
            values.Add(new DocValues { key = "wordcontrolgender", value = "Male" });
            values.Add(new DocValues { key = "wordcontrolnumber", value = "123123" });
            values.Add(new DocValues { key = "wordcontrolcountry", value = "Japan" });
            values.Add(new DocValues { key = "wordcontrolpin", value = "3213" });

            values.Add(new DocValues { key = "wordcontrolname2", value = "Shen" });
            values.Add(new DocValues { key = "wordcontrolage2", value = "24" });
            values.Add(new DocValues { key = "wordcontrolgender2", value = "Male" });
            values.Add(new DocValues { key = "wordcontrolnumber2", value = "1212331" });
            values.Add(new DocValues { key = "wordcontrolcountry2", value = "Japan" });
            values.Add(new DocValues { key = "wordcontrolpin2", value = "42343" });

            return values;
        }

        //internal static T Value<T>(IDataRecord reader, string fldName, T defaultVal)
        //{
        //    object o;

        //    for (int i = 0; i < reader.FieldCount; i++)
        //    {
        //        if (reader.GetName(i).Equals(fldName, StringComparison.OrdinalIgnoreCase))
        //        {
        //            o = reader[i];
        //            if (o != null && o != DBNull.Value)
        //            {
       
        //                return (T)Convert.ChangeType(o, typeof(T));
        //            }
        //            else
        //                return defaultVal;

        //        }
        //    }
        //    return defaultVal;
        //}


    }
}
