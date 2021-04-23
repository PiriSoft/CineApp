using Hangfire;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.BackgroundJop.Schedules
{
    //Çok kez (tekrarlı işler) ve belirtilmiş CRON süresince çalışır.
    public class RecurringJobs
    {
        [Obsolete]
        public static void DatabaseBackupOperation()
        {
            /*RemoveIfExists yönetimini çağırarak var olan yinelenen bir işi kaldırabilirsiniz.
                 Böyle tekrar eden bir iş olmadığından bir istisna oluşturmaz*/
            //RecurringJob.RemoveIfExists(nameof(DatebaseBackupScheduleJobManager));
            //RecurringJob.AddOrUpdate<DataBaseBackupScheduleJobManager>(nameof(DataBaseBackupScheduleJobManager),
            //    job => job.Process(),
            //    "59 23 * * *", TimeZoneInfo.Local
            //    );

        }
    }
}
