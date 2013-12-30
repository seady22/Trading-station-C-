using System.ServiceProcess;
using Quartz;
using Quartz.Impl;
using log4net;

namespace TradePlatform.MT4.SDK.QuartzService
{
    public partial class QuartzService : ServiceBase
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(QuartzService));
        public QuartzService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            ISchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler sched = schedFact.GetScheduler();
            sched.Start();
            _log.DebugFormat("Service was started");
        }

        protected override void OnStop()
        {
            _log.DebugFormat("Service was stoped");
        }
    }
}
