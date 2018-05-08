using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using FocusVision.Models;
using System.Web.Http.Cors;

namespace FocusVision.Controllers
{
    [Authorize]
    //[EnableCorsAttribute("*", "*", "*")]
    public class FocusVisionController : ApiController
    {
        public List<FocusVisionModels> Get()
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/test.json");
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var focusVisionList = ser.Deserialize<List<FocusVisionModels>>(Json);            
                return focusVisionList;
        }
    }
}
