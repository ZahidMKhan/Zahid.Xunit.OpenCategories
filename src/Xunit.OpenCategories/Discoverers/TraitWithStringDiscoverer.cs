using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories.Discoverers
{
    /// <summary>
    /// Abstract base class for trait discoverers that work with string values.
    /// </summary>
    /// <typeparam name="TDiscoverer">The type of the discoverer.</typeparam>
    public abstract class TraitWithStringDiscoverer<TDiscoverer> : BaseTraitDiscoverer<TDiscoverer>, ITraitDiscoverer
    {
        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            var value = traitAttribute.GetNamedArgument<string>(NamedArgumentName);

            if (!string.IsNullOrWhiteSpace(value))
            {
                yield return new KeyValuePair<string, string>(AttributeName, value);
            }
        }

        /// <summary>
        /// Gets the name of the named argument associated with the discoverer.
        /// </summary>
        protected abstract string NamedArgumentName { get; }
    }
}