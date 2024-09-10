using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="DatabaseTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DatabaseTestDiscoverer : TraitDiscoverer<DatabaseTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string AttributeName => "DatabaseTest";
    }
}