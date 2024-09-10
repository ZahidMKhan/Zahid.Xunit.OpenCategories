using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="KnownBugAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class KnownBugDiscoverer : TraitWithStringDiscoverer<KnownBugDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Id";
        
        /// <inheritdoc />
        protected override string AttributeName => "KnownBug";
    }
}