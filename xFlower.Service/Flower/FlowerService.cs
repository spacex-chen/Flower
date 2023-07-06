﻿using AutoMapper;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xFlower.Common;
using xFlower.Model.Entitys;

namespace xFlower.Service
{
    public class FlowerService : IFlowerService
    {
        private readonly IMapper _mapper;
        public FlowerService(IMapper mapper) 
        { 
            _mapper = mapper;
        }

        public List<FlowerRes> GetFlowers(FlowerReq req)
        {
            var res = DbContext.db.Queryable<Flower>().WhereIF(req.Id > 0, x => x.Id == req.Id).WhereIF(req.Type > 0, x => x.Type == req.Type).ToList();
            return _mapper.Map<List<FlowerRes>>(res);
        }
    }
}
