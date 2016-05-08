using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace ServiceStackSseExample.ServiceModel
{
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

    [Route("/slide")]
    public class GotoSlidePage
    {
        public int PageNumber { get; set; }
    }

    public class GotoSlidePageResponse
    {
        public int PageNumber { get; set; }
    }
}