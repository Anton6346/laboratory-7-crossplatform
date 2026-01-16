using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AuthService
{
    public async Task<bool> Login(string login, string password)
    {
        await Task.Delay(1500);
        return login == "admin" && password == "admin";
    }
}
