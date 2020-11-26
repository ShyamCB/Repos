using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceLender.DocOperations;

namespace WindowsServiceLender
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public string Ondebug(string fn)
        {
            string rettt=OnStart(fn);
            return rettt;
        }

        protected string OnStart(string args)
        {
            
            DocuServices doc = new DocuServices();
            if (args == "1")
            {
                string rett=doc.fillDocument();
                return "DOCUMENT FILLED";
             
            }
            else if (args == "2")
            {
                string ret=doc.SendForEsign();
                return ret;
            }
           else
            return "invalid input";
        }

        protected override void OnStop()
        {

        }
           
    }
}
