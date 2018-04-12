using CyberAcademy.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberAcademy.Web.Logics
{
    public class ContactManager
    {
        public IEnumerable<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact()
                {
                    ProfileImage = "images/profile.png",
                    Name = "Chuks Mabi"
                },
                  new Contact()
                {
                    ProfileImage = "images/profile.png",
                    Name = "Prolifik Lexzy",
                    IsActive= true
                },
                 new Contact()
                {
                    ProfileImage = "images/profile.png",
                    Name = "Hassan Liasu"
                },
                  new Contact()
                {
                    ProfileImage = "images/profile.png",
                    Name = "Muna Emmanuel"
                },
                  new Contact()
                {
                    ProfileImage = "images/profile.png"
                },
            };
        }
    }
}