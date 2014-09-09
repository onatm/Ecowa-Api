using Autofuzz.Dependency;
using Autofuzz.MongoDB;
using System.Collections.Generic;

namespace Ecowa.Data
{
    public class DataControlInitializer : IControlInitializer
    {
        public IEnumerable<RegistrationTarget> GetRegistrationTargets()
        {
            var controlList = new List<RegistrationTarget>();

            var repositoryAssembly = typeof(ICategoryRepository).Assembly;

            var repositoryTypes = AssemblyUtil.GetInterfacesWhichDerivesFromGenericInterface(repositoryAssembly, typeof(IFuzzMongoRepository<,>));

            controlList.Add(new RegistrationTarget(repositoryAssembly, repositoryTypes));

            return controlList;
        }
    }
}
