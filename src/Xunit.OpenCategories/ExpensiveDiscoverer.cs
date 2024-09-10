using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="ExpensiveAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ExpensiveDiscoverer : TraitDiscoverer<ExpensiveDiscoverer>
    {
        /// <inheritdoc />
        protected override string AttributeName => "Expensive";
    }
}