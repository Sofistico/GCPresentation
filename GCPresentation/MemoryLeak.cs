using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPresentation
{
    public static class MemoryLeak
    {
        public static void CauseMemoryLeak()
        {
            string str = " ";
            try
            {
                for (int i = 0; i < 30; i++)
                {
                    str += str;
                }
            }
            catch (Exception)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }

    public class Singleton
    {
        public static Singleton INSTANCE = new();

        private Singleton()
        {
        }
    }
}
