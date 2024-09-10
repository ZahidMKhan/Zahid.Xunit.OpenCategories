using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="CategoryAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CategoryDiscoverer : TraitWithStringDiscoverer<CategoryDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Name";
        
        /// <inheritdoc />
        protected override string AttributeName => "Category";
    }
}