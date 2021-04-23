using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.BackgroundJop.Schedules
{
    //Oluşturulduktan belirli bir (ayarlanan) zaman sonra sadece tek seferberliğine çalışan job türüdür.
    public class DelayedJobs
    {
        [Obsolete]
        public static void SendMailRegisterJobs(int userId)
        {
            //Hangfire.BackgroundJob.Schedule<UserRegisterScheduleJobManager>(
            //      job => job.Process(userId),
            //      TimeSpan.FromSeconds(20)
            //    );
        }
    }
}
