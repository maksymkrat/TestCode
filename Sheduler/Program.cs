using System;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace Sheduler
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           // DateTime dstDate = new DateTime( DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11,30,0);
           // DateTimeOffset thisTime = new DateTimeOffset(dstDate);
            
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();
            IJobDetail job = JobBuilder.Create<SomeWork>().Build();
            
            // ITrigger trigger = TriggerBuilder.Create()
            //     .WithIdentity("trigger", "group")
            //     .StartAt(thisTime).Build();

            var timeOfStart = new TimeSpan(14, 55, 30);
            var trigger = TriggerBuilder.Create()
                .WithSchedule(
                    CronScheduleBuilder.CronSchedule(
                        $"{timeOfStart.Seconds} {timeOfStart.Minutes} {timeOfStart.Hours} * * ?")).ForJob(job).Build();
            
            await scheduler.ScheduleJob(job, trigger);
            Console.WriteLine( DateTime.Now + " Start");
            Console.ReadKey();
        }
    }

    public  class SomeWork : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now + " I did something");
            return Task.CompletedTask;
        }
    }
}