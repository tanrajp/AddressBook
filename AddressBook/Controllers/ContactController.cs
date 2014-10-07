using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactController : ApiController
    {
        //
        // GET: /Client/

        public List<Contacts> Get()
        {
            return new List<Contacts>
                {
                    new Contacts{AddressId = 1, ForeName = "Mona", Surname ="Hunter" },
                    new Contacts{AddressId = 2, ForeName = "Nathan", Surname = "Pratt"},
                    new Contacts{AddressId = 3, ForeName = "Jennie", Surname ="Blair" }
                };
        }
 
        public List<Contacts> Get(int id)
        {
            return Get().Where(x => x.AddressId == id).ToList();
        }

    }
}
