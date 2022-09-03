using log4net;

namespace NetStandardReference
{
    public class NetStandardTestBed
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NetStandardTestBed));
        public static void DoLogging()
        {
            Logger.Error("Oh no!");
        }
    }
}
