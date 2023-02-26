using Hangfire.SqlServer;
using Hangfire;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

[assembly: OwinStartup(typeof(HangFireSample.App_Start.Startup))]

namespace HangFireSample.App_Start
{
    public class Startup
    {
        private IEnumerable<IDisposable> GetHangfireServers()
        {
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage("Server=.\\SQLEXPRESS; Database=HangfireTest; Integrated Security=True;", new SqlServerStorageOptions
                {
                    CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                    SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                    QueuePollInterval = TimeSpan.Zero,
                    UseRecommendedIsolationLevel = true,
                    DisableGlobalLocks = true
                });

            yield return new BackgroundJobServer();
        }

        public void Configuration(IAppBuilder app)
        {
            app.UseHangfireAspNet(GetHangfireServers);
            app.UseHangfireDashboard("/hangfire");

            // Let's also create a sample background job
            BackgroundJob.Enqueue(() => Debug.WriteLine("Hello world from Hangfire!"));
        }
    }
}
