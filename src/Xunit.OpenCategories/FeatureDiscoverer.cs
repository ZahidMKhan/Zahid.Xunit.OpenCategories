using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="FeatureAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class FeatureDiscoverer : TraitWithStringDiscoverer<FeatureDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Identifier";
        
        /// <inheritdoc />
        protected override string AttributeName => "Feature";
    }
}