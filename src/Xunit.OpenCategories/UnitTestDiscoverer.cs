using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="UnitTestAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class UnitTestDiscoverer : TraitWithStringDiscoverer<UnitTestDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Identifier";
        
        /// <inheritdoc />
        protected override string AttributeName => "UnitTest";
    }
}