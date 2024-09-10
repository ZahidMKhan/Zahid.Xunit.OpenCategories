using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="DocumentationAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DocumentationDiscoverer : TraitWithStringDiscoverer<DocumentationDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "WorkItemId";
        
        /// <inheritdoc />
        protected override string AttributeName => "Documentation";
    }
}