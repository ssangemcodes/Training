using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HangFireSample.Interfaces
{
    public interface IIPBackgroundJob
    {
        void GetDataForASite(int siteId);
    }
}