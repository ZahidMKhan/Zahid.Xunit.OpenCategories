using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories.Discoverers
{
    /// <summary>
    /// Abstract base class for trait discoverers.
    /// </summary>
    /// <typeparam name="TDiscoverer">The type of the discoverer.</typeparam>
    public abstract class TraitDiscoverer<TDiscoverer> : BaseTraitDiscoverer<TDiscoverer>, ITraitDiscoverer
    {
        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Yield a key-value pair representing the category as the attribute name
            yield return new KeyValuePair<string, string>("Category", AttributeName);
        }
    }
}