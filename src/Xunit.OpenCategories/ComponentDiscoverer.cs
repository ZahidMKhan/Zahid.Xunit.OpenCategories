using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="ComponentAttribute"/>.
    /// </summary>
    public class ComponentDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(ComponentDiscoverer);

        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the component information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "ComponentName" named argument from the trait attribute
            var name = traitAttribute.GetNamedArgument<string>("ComponentName");

            // Yield a key-value pair representing the category as "Component"
            yield return new KeyValuePair<string, string>("Category", "Component");

            // If the ComponentName is not null or whitespace, yield a key-value pair for the component information
            if (!string.IsNullOrWhiteSpace(name))
                yield return new KeyValuePair<string, string>("Component", name);
        }
    }
}