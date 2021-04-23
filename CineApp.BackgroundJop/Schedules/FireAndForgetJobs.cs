using System;
using System.Collections.Generic;
using System.Text;

namespace CineApp.BackgroundJop.Schedules
{
    //Bir kere ve hemen background job tipidir
    public class FireAndForgetJobs
    {
        //[Obsolete]
        //public static void SendMailJob(MailMesageDto mailMesaageDto)
        //{
        //    Hangfire.BackgroundJob.Enqueue<EmailSendingScheduleJobManager>(
        //        Job => Job.Process(mailMesaageDto));
        //}

        [Obsolete]
        public static void GetCurrencyJob()
        {
            //var jobId = Hangfire.BackgroundJob.Enqueue<CurrencyScheduleJobManager>(
            //    job => job.Process()
            //    );
            //ContinuationJobs.GetMyFinancialCashUpdate(jobId);
        }
    }
}
