using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetUsers.Entities;
using GetUsers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetUsers.Controllers
{

    public class UsersController : ControllerBase
    {
        //Refactorizare
        //Nameing Conversion
        //O baza de date facuta manual
        //O filtrare dupa nume si dupa age
        //O filtrare dupa adresa care o dau ca input
        // Toate astea cu Linq
        public readonly Users users;
        public readonly IService IService;

        public UsersController(IService iService,Users users)
        {
            this.IService = iService;
            this.users = users;
        }
        [HttpGet]
        [Route("api/users")]
        public List<Company> getAll()
        {
           

//            Company c = new Company();
//            c.CatchPhrase = "Da";
//            c.Id = 4;
//            c.Name = "Daaaa";
//            users.Company.Add(c);
//            users.SaveChanges();
            return users.Company.ToList();
        }
    }
}