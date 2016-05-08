using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStackSseExample.ServiceModel;

namespace ServiceStackSseExample.ServiceInterface
{
    public class MyServices : Service
    {
        public IServerEvents ServerEvents { get; set; }

        public GotoSlidePageResponse Any(GotoSlidePage request)
        {
            request.PageNumber++;
            ServerEvents.NotifyAll(request);
            return request.ConvertTo<GotoSlidePageResponse>();
        }
    }
}