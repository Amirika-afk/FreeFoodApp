using FreeFoodApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.Service
{
    public interface ILoginRepository
    {
        Task<userinfo>Login(string username, string password);
    }
}
