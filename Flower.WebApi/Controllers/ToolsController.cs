using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xFlower.Common;

namespace xFlower.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        [HttpGet]
        public void InitDatabase()
        {
            DbContext.InitDataBase();
        }
    }
}
