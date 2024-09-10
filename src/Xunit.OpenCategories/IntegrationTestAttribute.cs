using System;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    [TraitDiscoverer(IntegrationTestDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class IntegrationTestAttribute:Attribute, ITraitAttribute
    {

    }
}