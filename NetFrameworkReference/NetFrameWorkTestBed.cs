using log4net;

namespace NetFrameworkReference
{
    public class NetFrameWorkTestBed
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NetFrameWorkTestBed));
        public static void DoLogging()
        {
            Logger.Error("Oh no!");
        }
    }
}
