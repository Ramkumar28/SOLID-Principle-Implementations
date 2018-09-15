using System;
using System.Collections;
using System.Collections.Generic;
namespace SOLID_Example
{
    
    // Solution
    public interface IMessgae
    {
        string Sender{get;set;}
        void SendMessage();
        
        string Receiver{get;set;}
    }

    public class Email : IMessgae
    {
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Receiver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SendMessage()
        {
           //logic here.
        
        }
    }

    public class SMS : IMessgae
    {
        public string Sender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Receiver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SendMessage()
        {
            //Implementation goes here.
        }
    }

    public class Notification 
    {
        public IList<IMessgae> _messages;
        public Notification(IList<IMessgae> _messages)
        {
         this._messages = _messages;
        }

        public void SendMessages()
        {
        foreach(var message in _messages)
        {
            message.SendMessage();
        }
        }
    }
    // Below strucuture can be schanged by Dependency principle 

    // public class Email
    // {
    //     public string Sender{get;set;}
    //     public string Receiver{get;set;}
    //     public void SendMail()
    //     {
    //         Console.WriteLine("Mail will be sent.");
    //     }
    // }

    // public class SMS
    // {
    //     public string Sender{get;set;}
    //     public string Receiver{get;set;}

    //     public void SendSMS()
    //     {
    //         Console.WriteLine("SMS will be sent");
    //     }
    // }

    // public class Notification
    // {
    //     public Email _mail;
    //     public SMS _sms;

    //     public Notification()
    //     {
    //         _mail = new Email();
    //         _sms = new SMS();
    //     }
    //     public void Send()
    //     {
    //         _mail.SendMail();
    //         _sms.SendSMS();
    //     }
    // }
}