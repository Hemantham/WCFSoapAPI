using soapService.ActualRedPill;
using soapService.Models;
using soapService.RedPillReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace soapService
{
    /// <summary>
    /// Summary description for ContactsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ContactsService : System.Web.Services.WebService
    {      
        [WebMethod]
        //[OperationContract]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public ContactDetails WhoAreYou()
        {
            ContactDetails contact = new ContactDetails { EmailAddress = "hemantha.iris@gmail.com", FamilyName="Mudannayake", GivenName ="Hemantha", PhoneNumber="0499461061" };
            return contact;
        }

        [WebMethod]
        public long FibonacciNumber(long number)
        {
            RedPillClient redPillClient = new RedPillClient("BasicHttpBinding_IRedPill");
            return  redPillClient.FibonacciNumber(number);
        }

        [WebMethod]
        public string ReverseWords(string number)
        {
            RedPillClient redPillClient = new RedPillClient("BasicHttpBinding_IRedPill");
            return redPillClient.ReverseWords(number);
        }

        [WebMethod]
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            RedPillClient redPillClient = new RedPillClient("BasicHttpBinding_IRedPill");
            return redPillClient.WhatShapeIsThis(a,b,c);
        }        
    }
}
