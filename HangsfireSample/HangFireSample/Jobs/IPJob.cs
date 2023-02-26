using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using HangFireSample.Interfaces;

namespace HangFireSample.Jobs
{
    public class IPJob : IIPBackgroundJob
    {
        public void GetDataForASite(int siteId)
        {
            Thread.Sleep(2000);
        }
    }
}