using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xFlower.Model.Entitys;
using AutoMapper;
using xFlower.Service.User.Dto;

namespace xFlower.Service.Config
{
    public class AutoMapperConfigs : Profile
    {
        // 从A->B映射
        public AutoMapperConfigs() {
            CreateMap<Flower, FlowerRes>();
            CreateMap<Users, UserRes>();
            CreateMap<RegisterReq, Users>();
        }
    }
}
