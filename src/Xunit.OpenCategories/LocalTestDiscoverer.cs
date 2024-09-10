using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="LocalTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class LocalTestDiscoverer : TraitWithStringDiscoverer<LocalTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Id";

        /// <inheritdoc />
        protected override string AttributeName => "LocalTest";
    }
}