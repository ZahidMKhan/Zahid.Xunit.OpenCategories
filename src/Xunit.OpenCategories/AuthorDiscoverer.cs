using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    public class AuthorDiscoverer:ITraitDiscoverer
    {
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(AuthorDiscoverer);

        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var authorName = traitAttribute.GetNamedArgument<string>("AuthorName");

            if (!string.IsNullOrWhiteSpace(authorName))
                yield return new KeyValuePair<string, string>("Author", authorName);
        }
    }
}