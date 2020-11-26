using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WindowsServiceLender.DocOperations;
using System.IO;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using System.Xml;
using System.Security.AccessControl;
using System.Security.Principal;
using System.IO.Compression;
using WindowsServiceLender.Models;

namespace WindowsServiceLender
{
    public class DocuServices
    {
        public string fillDocument()
        {          

            string Path = ConfigurationManager.AppSettings["Docu1FilePath"];
            string base64WordDoc = Convert.ToBase64String(File.ReadAllBytes(Path));

            BuildDocuSignFields docu = new BuildDocuSignFields();
            var obj = docu.BuildDocFields();
            obj.FileBase64String = new WordReader().FillValuesToDoc(Convert.FromBase64String(base64WordDoc), "", obj);
            File.WriteAllBytes(@"D:\Visual Studio 2015\Projects\WindowsServiceLender\WindowsServiceLender\TestFilledDocs\TestFillDoc.docx", Convert.FromBase64String(obj.FileBase64String));
            return "DOCUMENT FILL SUCCESSFUL";
        }

        public string SendForEsign()
        {
            BuildDocuSignFields docusign = new BuildDocuSignFields();
            List<DocumentField.SendDocumentInfo> Docs = new List<DocumentField.SendDocumentInfo>();

            #region build Doc one

            string filepath1 = ConfigurationManager.AppSettings["Docu1FilePath"];
            string base64worddoc = Convert.ToBase64String(File.ReadAllBytes(filepath1));        

            var obj = docusign.BuildDocFields();

            obj.FileBase64String = new WordReader().FillValuesToDoc(Convert.FromBase64String(base64worddoc), "", obj);
            Docs.Add(obj);

            #endregion

            #region build Doc two
            string filepath2 = ConfigurationManager.AppSettings["Docu2FilePath"];
            string base64worddoc1 = Convert.ToBase64String(File.ReadAllBytes(filepath2));

            var obj1 = docusign.BuildDocFields();

            obj1.FileBase64String = new WordReader().FillValuesToDoc(Convert.FromBase64String(base64worddoc1), "", obj1);
            Docs.Add(obj1);
            #endregion

            #region Sending Document For E Signing

            DocuEsign esn = new DocuEsign();
            string docuID = esn.SendForESign(Docs);

            #endregion

            return docuID;
        }

    }
}
