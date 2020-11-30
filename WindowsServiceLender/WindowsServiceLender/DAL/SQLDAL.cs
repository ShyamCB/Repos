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



    }
}
