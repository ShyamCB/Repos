using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WindowsServiceLender.Models
{
    public class DocumentField
    {
        
        public class SendDocumentInfo
        {

           
            public string File_Sign { get; set; }
          
            public string FileType { get; set; }
            //[DataMember]
            public List<SignerInfo> SignerDetails { get; set; }
            //[DataMember]
            public List<SignerInfo> JointSignerDetails { get; set; }
            //[DataMember]
            public List<SignerInfo> CUSignerDetails { get; set; }

            public List<DocValues> DocuSignFields { get; set; }

            public string FileBase64String { get; set; }

            public bool IsInpersonSign { get; set; }// a bool to be set by user to check if imperson sign or not

        }
      
        public class SignerInfo
        {
            
            public string ReciName { get; set; }
           
            public string ReciEmail { get; set; }
           
            public string ReciId { get; set; }
            // public List<SignatureDetails> SignaturePosition { get; set; }
        }


     
        public class SignatureDetails
        {
           
            public string SignaturePos_X { get; set; }
           
            public string SignaturePos_Y { get; set; }
          
            public string SignaturePage { get; set; }
        }


        public class DocumentFields
        {
            #region textbox
            private string _lendername;
            public string wordcontrollendername
            {
                get { return _lendername ?? string.Empty; }
                set { _lendername = value; }

            }

            private string _address;
            public string wordcontroladdress
            {
                get { return _address ?? string.Empty; }
                set { _address = value; }

            }

            private string _lendercontact;
            public string wordcontrollendercontact
            {
                get { return _lendercontact ?? string.Empty; }
                set { _lendercontact = value; }

            }

            private string _lendercontactemail;

            public string wordcontrollenderemail
            {
                get { return _lendercontactemail ?? string.Empty; }
                set { _lendercontactemail = value; }
            }

            private string _city;

            public string wordcontrolcity
            {
                get { return _city ?? string.Empty; }
                set { _city = value; }
            }

            private string _ph;

            public string wordcontrolph
            {
                get { return _ph ?? string.Empty; }
                set { _ph = value; }
            }

            private string _lenderlocation;

            public string wordcontrollenderlocation
            {
                get { return _lenderlocation ?? string.Empty; }
                set { _lenderlocation = value; }
            }

            private string _st;

            public string wordcontrolst
            {
                get { return _st ?? string.Empty; }
                set { _st = value; }
            }

            private string _cell;

            public string wordcontrolcell
            {
                get { return _cell ?? string.Empty; }
                set { _cell = value; }
            }

            private string _title;

            public string wordcontroltitle
            {
                get { return _title ?? string.Empty; }
                set { _title = value; }
            }

            private string _legalname;
            public string wordcontrollegalname
            {
                get { return _legalname ?? string.Empty; }
                set { _legalname = value; }
            }

            private string _dba;
            public string wordcontroldba
            {
                get { return _dba ?? string.Empty; }
                set { _dba = value; }
            }

            private string _applicantaddress;
            public string wordcontrolapplicantaddress
            {
                get { return _applicantaddress ?? string.Empty; }
                set { _applicantaddress = value; }
            }

            private string _applicantcontact;
            public string wordcontrolapplicantcontact
            {
                get { return _applicantcontact ?? string.Empty; }
                set { _applicantcontact = value; }
            }
            private string _businesstax;
            public string wordcontrolbusinesstax
            {
                get { return _businesstax ?? string.Empty; }
                set { _businesstax = value; }
            }
            private string _citystate;
            public string wordcontrolcitystate
            {
                get { return _citystate ?? string.Empty; }
                set { _citystate = value; }
            }
            private string _phone;
            public string wordcontrolphone
            {
                get { return _phone ?? string.Empty; }
                set { _phone = value; }
            }
            private string _loanrequest;
            public string wordcontrolloanrequest
            {
                get { return _loanrequest ?? string.Empty; }
                set { _loanrequest = value; }
            }
            private string _guarantee;
            public string wordcontrolguarantee
            {
                get { return _guarantee ?? string.Empty; }
                set { _guarantee = value; }
            }

            private string _loanterm;

            public string wordcontrolloanterm
            {
                get { return _loanterm ?? string.Empty; }
                set { _loanterm = value; }
            }

            private string _payment;

            public string wordcontrolpayment
            {
                get { return _payment ?? string.Empty; }
                set { _payment = value; }
            }

            private string _intrestrate;

            public string wordcontrolintrestrate
            {
                get { return _intrestrate ?? string.Empty; }
                set { _intrestrate = value; }
            }

            private string _avgmonthlypayroll;

            public string wordcontrolavgmonthlypayroll
            {
                get { return _avgmonthlypayroll ?? string.Empty; }
                set { _avgmonthlypayroll = value; }
            }

            private string _disasterloan;

            public string wordcontroldisasterloan
            {
                get { return _disasterloan ?? string.Empty; }
                set { _disasterloan = value; }
            }

            private string _total;

            public string wordcontroltotal
            {
                get { return _total ?? string.Empty; }
                set { _total = value; }
            }

            private string _authorizedlender;

            public string wordcontrolauthorizedlender
            {
                get { return _authorizedlender ?? string.Empty; }
                set { _authorizedlender = value; }
            }

            private string _date;

            public string wordcontroldate
            {
                get { return _date ?? string.Empty; }
                set { _date = value; }
            }

            private string _title2;

            public string wordcontroltitle2
            {
                get { return _title2 ?? string.Empty; }
                set { _title2 = value; }
            }

            private string _name;

            public string wordcontrolname
            {
                get { return _name ?? string.Empty; }
                set { _name = value; }
            }
            #endregion

            #region checkbox
            ///check box

            private string _legalaction;

            public string chklegalaction
            {
                get { return _legalaction ?? string.Empty; }
                set { _legalaction = value; }
            }

            private string _protectionloan;

            public string chkprotection
            {
                get { return _protectionloan ?? string.Empty; }
                set { _protectionloan = value; }
            }

            private string _independentcontractor;

            public string chkindependantcontractor
            {
                get { return _independentcontractor ?? string.Empty; }
                set { _independentcontractor = value; }
            }

            private string _protectionprogram;

            public string chkpaycheckprotectionprogram
            {
                get { return _protectionprogram ?? string.Empty; }
                set { _protectionprogram = value; }
            }

            private string _franchisedirectory;

            public string chkfrachiseagreement
            {
                get { return _franchisedirectory ?? string.Empty; }
                set { _franchisedirectory = value; }
            }

            private string _pendinglawsuit;

            public string chkpendinglawsuit
            {
                get { return _pendinglawsuit ?? string.Empty; }
                set { _pendinglawsuit = value; }
            }

            private string _bankruptcy;

            public string chkbankruptcy
            {
                get { return _bankruptcy ?? string.Empty; }
                set { _bankruptcy = value; }
            }

            private string _guarantedloan;

            public string chksbaguaranteedloanlossgov
            {
                get { return _guarantedloan ?? string.Empty; }
                set { _guarantedloan = value; }
            }

            private string _usaresidence;

            public string chkusaresidence
            {
                get { return _usaresidence ?? string.Empty; }
                set { _usaresidence = value; }
            }

            private string _thirdparty;

            public string chkisthirdparty
            {
                get { return _thirdparty ?? string.Empty; }
                set { _thirdparty = value; }
            }
            #endregion

        }
    }
}
