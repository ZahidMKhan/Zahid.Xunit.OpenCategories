using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="DescriptionAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DescriptionDiscoverer : TraitWithStringDiscoverer<DescriptionDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Description";
        
        /// <inheritdoc />
        protected override string AttributeName => "Description";
    }
}