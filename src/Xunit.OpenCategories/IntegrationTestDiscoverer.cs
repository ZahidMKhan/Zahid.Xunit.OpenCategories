using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="IntegrationTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class IntegrationTestDiscoverer : TraitDiscoverer<IntegrationTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string AttributeName => "IntegrationTest";
    }
}