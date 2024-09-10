using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="ExploratoryAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ExploratoryDiscoverer : TraitWithStringDiscoverer<ExploratoryDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "WorkItemId";
        
        /// <inheritdoc />
        protected override string AttributeName => "Exploratory";
    }
}