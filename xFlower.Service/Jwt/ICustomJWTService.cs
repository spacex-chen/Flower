﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xFlower.Service.User.Dto;

namespace xFlower.Service
{
    public interface ICustomJWTService
    {
        //获取token
        string GetToken(UserRes user);
    }
}
