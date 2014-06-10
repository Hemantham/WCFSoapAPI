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
    /// <summary>
    /// The implementaion of red pill contract. The contract is created by adding a service reference to the redpill service. 
    /// This class wraps the operations operations exposed by http://KnockKnock.readify.net
    /// author : hemantha
    /// date : 07/06/14
    /// </summary>
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill 
    {
        public Actual.ContactDetails WhoAreYou()
        {
            Actual.ContactDetails contact = new Actual.ContactDetails { EmailAddress = @"hemantha.iris@gmail.com", FamilyName = "Mudannayake", GivenName = "Hemantha", PhoneNumber = "0499461061" };
            return contact;
        }
               
        public long FibonacciNumber(long number)
        {
            Actual.RedPillClient redPillClient = getRedPillClient();
            return redPillClient.FibonacciNumber(number);          
        } 
              
        public string ReverseWords(string number)
        {
            Actual.RedPillClient redPillClient = getRedPillClient();
            return redPillClient.ReverseWords(number);
        }
        
        public Actual.TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            Actual.RedPillClient redPillClient = getRedPillClient();
            return redPillClient.WhatShapeIsThis(a, b, c);
        }

        private static Actual.RedPillClient getRedPillClient()
        {
            Actual.RedPillClient redPillClient = getRedPillClient();
            return redPillClient;
        }
    }
}
