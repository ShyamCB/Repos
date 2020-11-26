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
           // envDef.EnforceSignerVisibility = "true";


           // Adding Signers// 

            #region ONE SIGNER
                         

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
                    signHere.RecipientId ="1";
                    signHere.AnchorString = "signhere1";
                    signHere.AnchorXOffset = "0";
                    signHere.AnchorYOffset = "0";
                    signHere.AnchorUnits = "inches";
                    signHere.AnchorIgnoreIfNotPresent = "false";
                    signer.Tabs.SignHereTabs.Add(signHere);

                    signer.ExcludedDocuments=new List<string>();
           
                  

                    envDef.Recipients.Signers.Add(signer);
                
                #endregion

            #region IN-PERSON Signer
                //bool _IsInperson = false;
                //string _inPersonHostEmail="";
                //string _inPersonHostName="";
                ////must be a docusign acc with inperson enabled
                ////In-person signing mode                                        

                //        InPersonSigner Impsigner = new InPersonSigner();
                //        Impsigner.Tabs = new Tabs();
                //        Impsigner.Tabs.SignHereTabs = new List<SignHere>();
                //        Impsigner.Tabs.DateSignedTabs = new List<DateSigned>();

                //        Impsigner.SignerName = "InpersonSigner One";
                //        Impsigner.RecipientId = "1";
                //        Impsigner.RoutingOrder ="1";
                //        Impsigner.InPersonSigningType = "inPersonSigner";
                //        Impsigner.HostName = _inPersonHostName;
                //        Impsigner.HostEmail = _inPersonHostEmail;

                      

                //            SignHere signHereImp = new SignHere();
                //            signHereImp.DocumentId = "1";
                //            signHereImp.RecipientId = "1";
                //            signHereImp.AnchorString = "SIGNHERE1";
                //            signHereImp.AnchorXOffset = "0";
                //            signHereImp.AnchorYOffset = "0";
                //            signHereImp.AnchorUnits = "inches";
                //            signHereImp.AnchorIgnoreIfNotPresent = "false";

                //         Impsigner.Tabs.SignHereTabs.Add(signHere);
                        
                //        DateSigned signed = new DateSigned();
                //        signed.DocumentId = "1";
                //        signed.RecipientId = "1";
                //        signed.AnchorString = "DATEHERE1";
                //        signed.AnchorXOffset = "0";
                //        signed.AnchorYOffset = "0";
                //        signed.AnchorUnits = "inches";
                //        signed.AnchorIgnoreIfNotPresent = "true";

                //        Impsigner.Tabs.DateSignedTabs.Add(signed);


                //        envDef.Recipients.InPersonSigners.Add(Impsigner);
                    

                
            
            #endregion

            #region Adding ONE Joint Signer
          
          
            
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
                    jointSignerTab.RecipientId ="2";
                    jointSignerTab.AnchorString = "SIGNHERE2";
                    jointSignerTab.AnchorXOffset = "0";
                    jointSignerTab.AnchorYOffset = "0";
                    jointSignerTab.AnchorUnits = "inches";
                    jointSignerTab.AnchorIgnoreIfNotPresent = "true";

                    jointSigner.Tabs.SignHereTabs.Add(jointSignerTab);

                    DateSigned jointSigned = new DateSigned();
                    jointSigned.DocumentId = "1";
                    jointSigned.RecipientId = "2";
                    jointSigned.AnchorString = "DATEHERE2";
                    jointSigned.AnchorXOffset = "0";
                    jointSigned.AnchorYOffset = "0";
                    jointSigned.AnchorUnits = "inches";
                    jointSigned.AnchorIgnoreIfNotPresent = "true";

                    jointSigner.Tabs.DateSignedTabs.Add(jointSigned);
                    envDef.Recipients.Signers.Add(jointSigner);

            
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
            string integratorKey = "82fc3ad6-2fc1-43cd-b398-3a1025c1174c";
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

            return loginInfo.LoginAccounts[0].AccountId;
        }
    }
}
