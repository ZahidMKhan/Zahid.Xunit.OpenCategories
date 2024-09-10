using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="WorkItemAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class WorkItemDiscoverer : TraitWithStringDiscoverer<WorkItemDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "WorkItemId";
        
        /// <inheritdoc />
        protected override string AttributeName => "WorkItem";
    }
}