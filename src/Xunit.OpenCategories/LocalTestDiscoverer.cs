using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="LocalTestAttribute"/>.
    /// </summary>
    public class LocalTestDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(LocalTestDiscoverer);

        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the local test information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "Id" named argument from the trait attribute
            var id = traitAttribute.GetNamedArgument<string>("Id");

            // Yield a key-value pair representing the category as "LocalTest"
            yield return new KeyValuePair<string, string>("Category", "LocalTest");

            // If the ID is not null or whitespace, yield a key-value pair for the local test information
            if (!string.IsNullOrWhiteSpace(id))
                yield return new KeyValuePair<string, string>("LocalTest", id);
        }
    }
}