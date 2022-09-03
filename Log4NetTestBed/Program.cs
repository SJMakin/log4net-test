namespace Log4NetTestBed
{
    public class Program
    {
        public static void Main()
        {
            NetStandardReference.NetStandardTestBed.DoLogging();
            NetFrameworkReference.NetFrameWorkTestBed.DoLogging();
        }
    }
}

