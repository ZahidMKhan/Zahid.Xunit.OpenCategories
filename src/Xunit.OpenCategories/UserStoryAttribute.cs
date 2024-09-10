using System;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    [TraitDiscoverer(UserStoryDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class UserStoryAttribute:Attribute, ITraitAttribute
    {
        public UserStoryAttribute()
        {

        }

        public UserStoryAttribute(string name)
        {
            this.Identifier = name;
        }

        public UserStoryAttribute(long id)
        {
            this.Identifier = id.ToString();
        }

        public string Identifier { get; private set; }

    }
}