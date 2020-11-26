using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceLender.Models;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using WindowsServiceLender.DAL;

namespace WindowsServiceLender.DocOperations
{
    class BuildDocuSignFields
    {
        public DocumentField.SendDocumentInfo BuildDocFields()
        {
            
            List<DocumentField.SignerInfo> signerdetails = new List<DocumentField.SignerInfo>();
            SQLDAL dal = new SQLDAL();
            DocumentField.SendDocumentInfo docf = new DocumentField.SendDocumentInfo();

            signerdetails.Add(new DocumentField.SignerInfo() { ReciName = "ReciName1", ReciEmail = "ReciEmail1", ReciId = "1" });
            signerdetails.Add(new DocumentField.SignerInfo() { ReciName = "ReciName2", ReciEmail = "ReciEmail2", ReciId = "2" });        
   
            docf.SignerDetails = signerdetails;
            docf.DocuSignFields= dal.MyConnection();

            return docf;

        }
    }
}
