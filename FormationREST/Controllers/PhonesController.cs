using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FormationREST.Controllers
{
    public class PhonesController : ApiController
    {
        [HttpGet]
        [Route("api/phones/all")]
        public IEnumerable<phone> GetBooks()
        {
            List<phone> phones = new List<phone>();
            phone p1 = new phone();
            p1.age=0;
            p1.id="motorola-xoom-with-wi-fi";
            p1.imageUrl="img/phones/motorola-xoom-with-wi-fi.0.jpg";
            p1.name="Motorola XOOM\u2122 with Wi-Fi";
            p1.snippet = "The Next, Next Generation\r\n\r\nExperience the future with Motorola XOOM with Wi-Fi, the world's first tablet powered by Android 3.0 (Honeycomb).";
            phones.Add(p1);
            phone p2 = new phone();
            p2.age=1;
            p2.id="motorola-xoom";
            p2.imageUrl="img/phones/motorola-xoom.0.jpg";
            p2.name="MOTOROLA XOOM\u2122";
            p2.snippet="The Next, Next Generation\n\nExperience the future with MOTOROLA XOOM, the world's first tablet powered by Android 3.0 (Honeycomb).";
            phones.Add(p2);
            phone p3 = new phone();
            p3.age =2;
            p3.id="motorola-atrix-4g";
            p3.imageUrl="img/phones/motorola-atrix-4g.0.jpg";
            p3.name="MOTOROLA ATRIX\u2122 4G";
            p3.snippet="MOTOROLA ATRIX 4G the world's most powerful smartphone.";
            phones.Add(p3);

            return phones;
        }
    }
}
