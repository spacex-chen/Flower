﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xFlower.Common;
using xFlower.Model.Entitys;
using xFlower.Model.Enum;
using xFlower.Service.User.Dto;

namespace xFlower.Service.User
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserRes GetUsers(UserReq req)
        {
            var user = DbContext.db.Queryable<Users>().First(p => p.UserName == req.UserName && p.Password == req.Password);
            if (user != null)
            {
                return _mapper.Map<UserRes>(user);
            }
            return new UserRes();
        }

        public UserRes RegisterUser(RegisterReq req, ref string msg)
        {
            var user = DbContext.db.Queryable<Users>().First(p => p.UserName == req.UserName);
            if (user != null)
            {
                msg = "账号已存在！";
                return _mapper.Map<UserRes>(user);
            }
            else
            {
                try
                {
                    Users users = _mapper.Map<Users>(req);
                    users.CreateTime = DateTime.Now;
                    users.UserType = (int)EnumUserType.普通用户;
                    bool res = DbContext.db.Insertable(users).ExecuteCommand() > 0;
                    if (res)
                    {
                        user = DbContext.db.Queryable<Users>().First(p => p.UserName == req.UserName && p.Password == req.Password);
                        return _mapper.Map<UserRes>(user);
                    }
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
            }
            return new UserRes();
        }
    }
}
