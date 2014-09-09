using Autofuzz.Dependency;
using System;
using System.Collections.Generic;

namespace Ecowa.Business
{
    public class BusinessControlInitializer : IControlInitializer
    {
        public IEnumerable<RegistrationTarget> GetRegistrationTargets()
        {
            var controlList = new List<RegistrationTarget>();

            var serviceAssembly = typeof(ICategoryService).Assembly;

            var serviceTypes = AssemblyUtil.GetInterfacesWhichDerivesFromGenericInterface(serviceAssembly, typeof(IService<,>));

            controlList.Add(new RegistrationTarget(serviceAssembly, serviceTypes));
            controlList.Add(new RegistrationTarget(serviceAssembly, new Type[] { typeof(IEcowaBusiness) }));

            return controlList;
        }
    }
}
