using System;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{

    [TraitDiscoverer(SystemTestDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SystemTestAttribute : Attribute, ITraitAttribute
    {
        public SystemTestAttribute(string id)
        {
            this.Id = id;
        }

        public SystemTestAttribute(long id)
        {
            this.Id = id.ToString();
        }

        public SystemTestAttribute()
        {

        }

        public string Id { get; private set; }
    }
}
