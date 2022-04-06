using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface ISmsServiceProvider
    {
        void SendSms(string cellPhone);
    }

    public class AServiceProvider:ISmsServiceProvider
    {

        public void SendSms(string cellPhone)
        {
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }

    public class BServiceProvider:ISmsServiceProvider
    {

        public void SendSms(string cellPhone)
        {
            Console.WriteLine($"Sending SMS to cell phone: {cellPhone}");
        }
    }
    public class Person
    {
        private readonly ISmsServiceProvider _smsServiceProvider;
        
        public Person(ISmsServiceProvider smsServiceProvider)
        {
          _smsServiceProvider = smsServiceProvider;    
        }
        public void DeliveryMessage(string cellphone)
        {
          _smsServiceProvider.SendSms(cellphone);   
        }
    }





}
