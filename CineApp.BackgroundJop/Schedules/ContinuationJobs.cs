using Hangfire;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.BackgroundJop.Schedules
{
    public class ContinuationJobs
    {
        //Birbiri ile ilişkili işelerin olduğu zaman çalışan job.job tetiklenmesi için başka bir job bitmesi gerekiyor. 
        [Obsolete]
        [AutomaticRetry(Attempts = 7)]
        public static void GetMyFinancilCashUpdate(string id)
        {
            //Hangfire.BackgroundJob.ContinueJobWith<FinancialCashScheduleJobManager>(
            //    parentId: id,
            //    job => job.Process()
            //    );
        }
        //farklı işler yapan methodlar burada tanımlana bilir tabi connectionsjob türünde çalışan
    }
}
