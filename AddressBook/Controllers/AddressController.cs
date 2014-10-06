using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class AddressController : ApiController
    {
        //
        // GET: /Address/
        public List<Address> Get()
        {
            return new List<Address>
                {
                    new Address{Id = 1, HouseNumber = 11, AddressLine1 = "Hoxton Square", AddressLine2 = null, City = "London", PostCode = "N1 6NU" },
                    new Address{Id = 2, HouseNumber = 40, AddressLine1 = "Horsefair Green", AddressLine2 = null, City = "Birmingham", PostCode = "OL1 9TY" },
                    new Address{Id = 3, HouseNumber = 41, AddressLine1 = "Lillingstone", AddressLine2 = "Dayrell", City = "Manchester", PostCode = "MK18 5EH" },
                };
        } 
    }

}
