using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using FashionSiteEntityLibrary;
using FashionSiteEntityLibrary.AdminInformationEntity;

namespace FashionSite.Model
{
    public class LoginCore : System.Web.Mvc.AuthorizeAttribute
    {
        AdminInformationTable _adminInformationTable;
       private readonly FashionSiteContext _FashionSiteContext;
        public LoginCore()
        {
            _adminInformationTable = new AdminInformationTable();
            _FashionSiteContext = new FashionSiteContext();
        }
        public bool Status;
        public void Log(string userName, string userPassword)
        {
            try
            {
                AdminInformationTable adminTable = (from p in _FashionSiteContext.Admin select p).First();

                if (userName == adminTable.AdminName && userPassword == adminTable.AdminPassword)
                {
                    Status = true;
                }
                else
                {
                    Status = false;
                }


            }
            catch (Exception)
            {

                _adminInformationTable.AdminName = "site";
                _adminInformationTable.AdminPassword = "123456";
                using (FashionSiteContext db = new FashionSiteContext())
                {
                    db.Admin.Add(_adminInformationTable);
                    db.SaveChanges();
                }

                _adminInformationTable = (from p in _FashionSiteContext.Admin select p).First();


                if (userName == _adminInformationTable.AdminName && userPassword == _adminInformationTable.AdminPassword)
                {
                    Status = true;
                }
                else
                {
                    Status = false;
                }

            }

        }

    }

}
