using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="SpecificationAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SpecificationDiscoverer : TraitWithStringDiscoverer<SpecificationDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Identifier";

        /// <inheritdoc />
        protected override string AttributeName => "Specification";
    }
}