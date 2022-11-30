using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Account 
    {
        private string emailAddress;
        private string name;
        private AddressBook nwm;

        public Account(AddressBook anwm)
        {
            this.nwm = anwm;
        }

        public string getEmailAddress()
        {
            return emailAddress;
        }
        public string getName()
        {
            return name;
        }
        public void setEmailAddress()
        {

        }
        public void SetName()
        {

        }
    }
    class Contact
    {
        private string emailaddress;
        private string faxNumber;
        private string name;
        private string primaryContactMethod;

        public string getEmailAddress()
        {
            return emailaddress;
        }
        public string getFaxNumber()
        {
            return faxNumber;
        }
        public string getname()
        {
            return name;
        }
        public string getPrimarcyContactMethod()
        {
            return primaryContactMethod;
        }
        public void setEmailAddress()
        {

        }
        public void setfaxNumber()
        {

        }
        public void setName()
        {

        }
        public void setPrimarcyContactMethhod()
        {

        }
    }
    class ContactGroup
    {
        private string name;

        public string getName()
        {
            return name;
        }
        public string setName()
        {
            return name;
        }
    }
    class AddressBook
    {
        private string name;
        private Contact contact;
        public AddressBook(Contact acontact)
        {
            this.contact = acontact;
        }
        public void getContact()
        {

        }
        public void getContacts()
        {

        }
        public string getName()
        {
            return name;
        }
        public void insertContact()
        {

        }
        public void setName()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mmm");
        }
    }
}
