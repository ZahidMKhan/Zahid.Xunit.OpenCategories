using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="SpecificationAttribute"/>.
    /// </summary>
    public class SpecificationDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(SpecificationDiscoverer);

        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the specification test information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "Identifier" named argument from the trait attribute
            var name = traitAttribute.GetNamedArgument<string>("Identifier");

            // Yield a key-value pair representing the category as "Specification"
            yield return new KeyValuePair<string, string>("Category", "Specification");

            // If the Identifier is not null or whitespace, yield a key-value pair for the specification information
            if (!string.IsNullOrWhiteSpace(name))
                yield return new KeyValuePair<string, string>("Specification", name);
        }
    }
}