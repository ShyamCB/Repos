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
            SQLDAL dal = new SQLDAL();
            List<DocumentField.SignerInfo> signerdetails = new List<DocumentField.SignerInfo>();            
            DocumentField.SendDocumentInfo docf = new DocumentField.SendDocumentInfo();               
          
            docf.DocuSignFields= dal.MyConnection();

            return docf;

        }
    }
}
