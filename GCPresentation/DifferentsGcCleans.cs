namespace GCPresentation
{
    public static class DifferentsGcCleans
    {
        public static void GcGensExamples()
        {
            GC0();
            GC1();
            GC2();
        }

        private static void GC1()
        {
            var obj = new object();
            GC.Collect();
            Console.WriteLine("obj é da geração " + GC.GetGeneration(obj));
        }

        private static void GC2()
        {
            var obj = new object();
            GC.Collect();
            GC.Collect();
            Console.WriteLine("obj é da geração " + GC.GetGeneration(obj));
        }

        private static void GC0()
        {
            // Create an object in Generation 0.
            Object obj = new Object();
            Console.WriteLine("obj é da geração " + GC.GetGeneration(obj));
        }
    }
}
