using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="SnapshotTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class SnapshotTestDiscoverer : TraitDiscoverer<SnapshotTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string AttributeName => "SnapshotTest";
    }
}