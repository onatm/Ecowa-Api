using Autofuzz.Dependency;

namespace Ecowa.Data
{
    public static class DataControlStartUp
    {
        public static void Run()
        {
            ServiceControl.Initialize(new DataControlInitializer());
        }
    }
}
