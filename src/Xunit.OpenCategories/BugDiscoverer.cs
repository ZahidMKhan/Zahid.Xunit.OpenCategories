using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="BugAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BugDiscoverer : TraitWithStringDiscoverer<BugDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Id";
        
        /// <inheritdoc />
        protected override string AttributeName => "Bug";
    }
}