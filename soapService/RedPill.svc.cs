using soapService.RedPillReference;
using  Actual = soapService.ActualRedPill ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace soapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    // [ServiceContract(Namespace = @"http://aspspider.ws/hemantham/")]
    // [ServiceContract(Namespace = @"http://localhost:58341/IRedPill")]

    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill 
    {
        public Actual.ContactDetails WhoAreYou()
        {
            Actual.ContactDetails contact = new Actual.ContactDetails { EmailAddress = "hemantha.iris@gmail.com", FamilyName = "Mudannayake", GivenName = "Hemantha", PhoneNumber = "0499461061" };
            return contact;
        }

       
        public long FibonacciNumber(long number)
        {
            Actual.RedPillClient redPillClient = new Actual.RedPillClient("BasicHttpBinding_IRedPill1");
            return redPillClient.FibonacciNumber(number);          
        }

      
        public string ReverseWords(string number)
        {
            Actual.RedPillClient redPillClient = new Actual.RedPillClient("BasicHttpBinding_IRedPill1");
            return redPillClient.ReverseWords(number);
        }


        public Actual.TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            Actual.RedPillClient redPillClient = new Actual.RedPillClient("BasicHttpBinding_IRedPill1");
            return redPillClient.WhatShapeIsThis(a, b, c);
        }        
    }
}
