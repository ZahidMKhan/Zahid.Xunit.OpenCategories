using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="TestCaseAttribute"/>.
    /// </summary>
    public class TestCaseDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(TestCaseDiscoverer);

        /// <summary>
        /// Gets the trait values from the trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the test case information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "TestCaseId" named argument from the trait attribute
            var testCaseId = traitAttribute.GetNamedArgument<string>("TestCaseId");

            // Yield a key-value pair representing the category as "TestCase"
            yield return new KeyValuePair<string, string>("Category", "TestCase");

            // If the TestCaseId is not null or whitespace, yield a key-value pair for the test case information
            if (!string.IsNullOrWhiteSpace(testCaseId))
                yield return new KeyValuePair<string, string>("TestCase", testCaseId);
        }
    }
}