using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook // this class is responsible for managing contact list
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();//this is private field bcz we dont want anyone outside the class to modify the contact list

        private void DisplayContactDetails(Contact contact) //creating p.method to display contacts
        {
            Console.WriteLine($"Contact: {contact.Name},{contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void AddContact(Contact contact) // this method is to Add contacts to contactlist ,taking parameter as  contact object
        {
            contacts.Add(contact);
        }

        public void DisplayContact(string number) // this method is to display a contact by numb,tat will accept string num as parameter
        {
            var contact = contacts.FirstOrDefault(c => c.Number == number); //will b able to get the merged contact based on lambda expression
                                                                            //x => x.Number == number - lambda exp by doing tat we either get null value if contact is not found based on numb or some speific contact

            if (contact == null)
            {
                Console.WriteLine("contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        // to display all contacts from phonebook so creating one more method DisplayAllContact()

        public void DisplayAllContact()
        {
            DisplayContactDetails(contacts);
        }

        public void DisplayMatchingContacts(string searchphraase)
        {
            // named:sahil
            //searchphrase:sa 
            var matchingContacts = contacts.Where(c => c.Name.Contains(searchphraase)).ToList();
            DisplayContactDetails(matchingContacts);

        }
    }
}