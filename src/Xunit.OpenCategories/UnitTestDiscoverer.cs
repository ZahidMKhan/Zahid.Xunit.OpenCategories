using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="UnitTestAttribute"/>.
    /// </summary>
    public class UnitTestDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(UnitTestDiscoverer);

        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the unit test information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "Identifier" named argument from the trait attribute
            var name = traitAttribute.GetNamedArgument<string>("Identifier");

            // Yield a key-value pair representing the category as "UnitTest"
            yield return new KeyValuePair<string, string>("Category", "UnitTest");

            // If the Identifier is not null or whitespace, yield a key-value pair for the unit test information
            if (!string.IsNullOrWhiteSpace(name))
                yield return new KeyValuePair<string, string>("UnitTest", name);
        }
    }
}