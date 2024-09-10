using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="SystemTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SystemTestDiscoverer : TraitWithStringDiscoverer<SystemTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Id";

        /// <inheritdoc />
        protected override string AttributeName => "SystemTest";
    }
}