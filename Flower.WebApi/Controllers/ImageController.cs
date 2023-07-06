using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace xFlower.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        //获取图片路由的方法
        [HttpGet]
        public List<ImageModel> GetImages()
        {
            return new List<ImageModel>()
            {
                new ImageModel() {ImageUrl = "/images/banners/21_birthday_banner_pc.jpg", CourseUrl = "https://www.hua.com/"},
                new ImageModel() {ImageUrl = "/images/banners/21_brand_banner_pc.jpg", CourseUrl = "https://www.hua.com/"},
                new ImageModel() {ImageUrl = "/images/banners/21_syz_banner_pc.jpg", CourseUrl = "https://www.hua.com/"}
            };
        }
    }
}
