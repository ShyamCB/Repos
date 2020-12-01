using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceLender.Models;



namespace WindowsServiceLender.DocOperations
{
    class DocuEsign
    {
        public string SendForESign(List<DocumentField.SendDocumentInfo> docs)
        {
            bool _IsInperson = true;

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "Email subject";
            envDef.EmailBlurb = "Email blurb";
            envDef.Documents = new List<Document>();
            

            #region Adding Doc One

            Document doc1 = new Document();
            doc1.DocumentBase64 = docs[0].FileBase64String;
            doc1.Name = "document one";
            doc1.DocumentId = "1";
            doc1.FileExtension = "docx";
            doc1.Pages = "1";
            
       
            envDef.Documents.Add(doc1);

            #endregion

            #region Addding Doc Two

            Document doc2 = new Document();
            doc2.DocumentBase64 = docs[1].FileBase64String;
            doc2.Name = "documnet two";
            doc2.DocumentId = "2";
            doc2.FileExtension = "docx";
            doc2.Pages = "1";

            envDef.Documents.Add(doc2);
            #endregion


            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.InPersonSigners = new List<InPersonSigner>();
            //envDef.EnforceSignerVisibility = "true";


            // Adding Signers// 

            #region ONE SIGNER

            if (!_IsInperson)
            {
                Signer signer = new Signer();
                signer.Tabs = new Tabs();
                signer.Tabs.SignHereTabs = new List<SignHere>();
                signer.Tabs.CheckboxTabs = new List<Checkbox>();
                signer.Tabs.DateSignedTabs = new List<DateSigned>();

                signer.Name = "Signer One";
                signer.Email = ConfigurationManager.AppSettings["Reci1Email"];

                signer.RecipientId = "1";
                signer.RoutingOrder = "1";

                SignHere signHere = new SignHere();
                signHere.DocumentId = "1";
                signHere.RecipientId = "1";
                signHere.AnchorString = "signhere1";
                signHere.AnchorXOffset = "0";
                signHere.AnchorYOffset = "0";
                signHere.AnchorUnits = "inches";
                signHere.AnchorIgnoreIfNotPresent = "false";
                signer.Tabs.SignHereTabs.Add(signHere);

                DateSigned Datesign = new DateSigned();
                Datesign.DocumentId = "1";
                Datesign.RecipientId = "2";
                Datesign.AnchorString = "DATEHERE1";
                Datesign.AnchorXOffset = "0";
                Datesign.AnchorYOffset = "0";
                Datesign.AnchorUnits = "inches";
                Datesign.AnchorIgnoreIfNotPresent = "true";
                signer.Tabs.DateSignedTabs.Add(Datesign);

                envDef.Recipients.Signers.Add(signer);
            }
            #endregion

            #region IN-PERSON Signer
           
         
            //must be a docusign acc with inperson enabled
            //In-person signing mode                                        
            if (_IsInperson)
            {
                #region impsigner1
                InPersonSigner Impsigner = new InPersonSigner();
                Impsigner.Tabs = new Tabs();
                Impsigner.Tabs.SignHereTabs = new List<SignHere>();
                Impsigner.Tabs.DateSignedTabs = new List<DateSigned>();

                Impsigner.SignerName = "InpersonSigner one";
                Impsigner.RecipientId = "1";
                Impsigner.RoutingOrder = "1";
                Impsigner.InPersonSigningType = "inPersonSigner";
                Impsigner.HostName = "inperson host";
                Impsigner.HostEmail = ConfigurationManager.AppSettings["ImpHostEmail"] ;



                SignHere signHereImp = new SignHere();
                signHereImp.DocumentId = "1";
                signHereImp.RecipientId = "1";
                signHereImp.AnchorString = "SIGNHERE1";
                signHereImp.AnchorXOffset = "0";
                signHereImp.AnchorYOffset = "0";
                signHereImp.AnchorUnits = "inches";
                signHereImp.AnchorIgnoreIfNotPresent = "false";

                Impsigner.Tabs.SignHereTabs.Add(signHereImp);

                DateSigned signed = new DateSigned();
                signed.DocumentId = "1";
                signed.RecipientId = "1";
                signed.AnchorString = "DATEHERE1";
                signed.AnchorXOffset = "0";
                signed.AnchorYOffset = "0";
                signed.AnchorUnits = "inches";
                signed.AnchorIgnoreIfNotPresent = "true";

                Impsigner.Tabs.DateSignedTabs.Add(signed);


                envDef.Recipients.InPersonSigners.Add(Impsigner);
                #endregion

                #region ImpSigner2
                InPersonSigner Impsigner2 = new InPersonSigner();
                Impsigner2.Tabs = new Tabs();
                Impsigner2.Tabs.SignHereTabs = new List<SignHere>();
                Impsigner2.Tabs.DateSignedTabs = new List<DateSigned>();

                Impsigner2.SignerName = "InpersonSigner two";
                Impsigner2.RecipientId = "2";
                Impsigner2.RoutingOrder = "2";
                Impsigner2.InPersonSigningType = "inPersonSigner";
                Impsigner2.HostName = "inperson host";
                Impsigner2.HostEmail = ConfigurationManager.AppSettings["ImpHostEmail"];



                SignHere signHereImp2 = new SignHere();
                signHereImp2.DocumentId = "2";
                signHereImp2.RecipientId = "1";
                signHereImp2.AnchorString = "SIGNHERE2";
                signHereImp2.AnchorXOffset = "0";
                signHereImp2.AnchorYOffset = "0";
                signHereImp2.AnchorUnits = "inches";
                signHereImp2.AnchorIgnoreIfNotPresent = "false";

                Impsigner2.Tabs.SignHereTabs.Add(signHereImp2);

                DateSigned signed2 = new DateSigned();
                signed2.DocumentId = "1";
                signed2.RecipientId = "1";
                signed2.AnchorString = "DATEHERE2";
                signed2.AnchorXOffset = "0";
                signed2.AnchorYOffset = "0";
                signed2.AnchorUnits = "inches";
                signed2.AnchorIgnoreIfNotPresent = "true";

                Impsigner2.Tabs.DateSignedTabs.Add(signed2);
                

                envDef.Recipients.InPersonSigners.Add(Impsigner2);

            }



            #endregion

            #region Adding ONE Joint Signer

            if (!_IsInperson)
            {

                Signer jointSigner = new Signer();
                jointSigner.Tabs = new Tabs();
                jointSigner.Tabs.SignHereTabs = new List<SignHere>();
                jointSigner.Tabs.DateSignedTabs = new List<DateSigned>();

                jointSigner.Name = "Joint Signer 1";
                jointSigner.Email = ConfigurationManager.AppSettings["Reci2Email"];
                jointSigner.RecipientId = "2";
                jointSigner.RoutingOrder = "2";

                SignHere jointSignerTab = new SignHere();
                jointSignerTab.DocumentId = "1";
                jointSignerTab.RecipientId = "2";
                jointSignerTab.AnchorString = "SIGNHERE2";
                jointSignerTab.AnchorXOffset = "0";
                jointSignerTab.AnchorYOffset = "0";
                jointSignerTab.AnchorUnits = "inches";
                jointSignerTab.AnchorIgnoreIfNotPresent = "true";

                jointSigner.Tabs.SignHereTabs.Add(jointSignerTab);

                DateSigned JODateSigned = new DateSigned();
                JODateSigned.DocumentId = "1";
                JODateSigned.RecipientId = "2";
                JODateSigned.AnchorString = "DATEHERE2";
                JODateSigned.AnchorXOffset = "0";
                JODateSigned.AnchorYOffset = "0";
                JODateSigned.AnchorUnits = "inches";
                JODateSigned.AnchorIgnoreIfNotPresent = "true";

                jointSigner.Tabs.DateSignedTabs.Add(JODateSigned);

                envDef.Recipients.Signers.Add(jointSigner);

            }
            #endregion
     

            #region ATTEMP SEND ENVELOPE

            envDef.Status = "sent";
           
            string accountId = GetAccountID();
            EnvelopesApi envelopesApi = new EnvelopesApi();
            
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);

            #endregion

            var returnEnv = envelopesApi.GetEnvelope(accountId, envelopeSummary.EnvelopeId, null); //sending for e-sign
            string status = returnEnv.Status;

            return envelopeSummary.EnvelopeId;
        }
        public string GetAccountID()
        {

            #region auth_details
            string integratorKey = ConfigurationManager.AppSettings["IntegratorKey"];
            string email = ConfigurationManager.AppSettings["DocuSignUserEmail"]; 
            string password = ConfigurationManager.AppSettings["DocuSignPassword"];

            string authHeader = "{\"Username\":\"" + email + "\", \"Password\":\"" + password + "\", \"IntegratorKey\":\"" + integratorKey + "\"}";
            #endregion

            DocuSign.eSign.Client.Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

            #region attemptlogin
            ApiClient client = new ApiClient(basePath: "https://demo.docusign.net/restapi");
            DocuSign.eSign.Client.Configuration configHeader = new DocuSign.eSign.Client.Configuration(client);
            configHeader.AddDefaultHeader("X-DocuSign-Authentication", authHeader);
            AuthenticationApi authApi = new AuthenticationApi(configHeader);

            
            LoginInformation loginInfo = authApi.Login();
         
            #endregion

            return loginInfo.LoginAccounts[1].AccountId;
        }
    }
}
#endregion