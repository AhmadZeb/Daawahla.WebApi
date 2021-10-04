using Daawahla.Core.Entities.AuthModel;
using Daawahla.Core.Entities.UserModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.JWTAuthManager
{
    public interface IJWTAuthManager
    {
        Response<string> GenerateJWT(User user);
        Response<T> Execute_Command<T>(string query, DynamicParameters sp_params);
        Response<List<T>> getUserList<T>();
    }
}
