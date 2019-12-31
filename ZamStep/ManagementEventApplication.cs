using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Config;
namespace SSR
{
    public class ManagementEventApplication
    {
        private static ManagementEventApplication singleton = null;
        private static readonly object padlock = new object();

        public static ManagementEventApplication Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new ManagementEventApplication();
                    return singleton;
                }
            }
        }
        public  ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


    }
}
