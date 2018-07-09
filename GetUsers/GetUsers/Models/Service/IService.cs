using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetUsers.Entities;
namespace GetUsers.Models
{
    public interface IService
    {
        string GetUsers();
        void Initialization();
        void GetUsersApi();

    }
}
