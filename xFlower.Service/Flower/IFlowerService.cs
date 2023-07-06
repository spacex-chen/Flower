using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xFlower.Service
{
    public interface IFlowerService
    {
        public List<FlowerRes> GetFlowers(FlowerReq req);
    }
}
