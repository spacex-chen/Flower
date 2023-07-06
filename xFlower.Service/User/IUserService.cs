using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xFlower.Service.User.Dto;

namespace xFlower.Service.User
{
    public interface IUserService
    {
        UserRes GetUsers(UserReq req);
        UserRes RegisterUser(RegisterReq req, ref string msg);
    }
}
