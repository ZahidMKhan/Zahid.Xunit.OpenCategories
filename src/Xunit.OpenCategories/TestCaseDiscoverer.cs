using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="TestCaseAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class TestCaseDiscoverer : TraitWithStringDiscoverer<TestCaseDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "TestCaseId";
        
        /// <inheritdoc />
        protected override string AttributeName => "TestCase";
    }
}