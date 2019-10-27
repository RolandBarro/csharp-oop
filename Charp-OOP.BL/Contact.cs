using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp_OOP.BL
{
    public class Contact
    {
        public Contact()
        {
        }
        public Contact(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string GetFullName()
        {
            string fullName = LastName;
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }

                fullName += FirstName;
            }

            return fullName;
        }

        public static int InstanceCount { get; set; }

        /// <summary>
        /// Validates the Contact data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve Contact by Id.
        /// </summary>
        /// <returns></returns>
        public Contact Retrieve(int Id) { 
            return new Contact();
        }

        /// <summary>
        /// Retrieve List of Contacts.
        /// </summary>
        /// <returns></returns>
        public List<Contact> Retrieve()
        {
            return new List<Contact>();
        }

        /// <summary>
        /// Save a Contact.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
