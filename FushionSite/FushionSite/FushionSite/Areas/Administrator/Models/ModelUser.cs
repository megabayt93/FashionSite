using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.AdminInformationEntity;
using FashionSiteEntityLibrary.ContactEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionSite.Areas.Administrator.Models
{
    public class ModelUser
    {
       private readonly FashionSiteContext _adminContext;
       
       private readonly AdminInformationTable _adminTable;
       private  readonly ContactsTable _contactTable;

        public ModelUser()
        {
            _contactTable = new ContactsTable();
            _adminContext = new FashionSiteContext();
            _adminTable = new AdminInformationTable();
        }
        public bool UpdateAdmin(string adminName,string oldPassword, string newPassword)
        {

            var comingAdmin = (from p in _adminContext.Admin select p).First(cId => cId.AdminId > 0);
            if (oldPassword == comingAdmin.AdminPassword)
            {

                comingAdmin.AdminName = adminName;
                comingAdmin.AdminPassword = newPassword;
                _adminContext.SaveChanges();

              
                return true; 
               
                
            }
            else
            {
                return false;

            }
        }

        public void ContactUpdate(string contactContent)
        {
            try
            {
                var comingContact = _adminContext.Contacts.First(cId => cId.ContactId > 0); 
                comingContact.ContactContent = contactContent;
               
                _adminContext.SaveChanges();
            }
            catch (Exception)
            {

                _contactTable.ContactContent = contactContent;
             
                _adminContext.Contacts.Add(_contactTable);     
                _adminContext.SaveChanges();
            }
          

        }

     
       
    }
}