using Autofac;
using Autofuzz.Dependency;
using AutoMapper;
using Ecowa.Data;

namespace Ecowa.Business
{
    public static class BusinessControlStartUp
    {
        public static void Run()
        {
            DataControlStartUp.Run();
            MappingConfig.RegisterMappings();
            ServiceControl.Builder.Register(_ => Mapper.Engine).As<IMappingEngine>().SingleInstance();
            ServiceControl.Initialize(new BusinessControlInitializer());
        }
    }
}
