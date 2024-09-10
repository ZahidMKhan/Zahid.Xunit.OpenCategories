using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="AuthorAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AuthorDiscoverer : TraitWithStringDiscoverer<AuthorDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "AuthorName";

        /// <inheritdoc />
        protected override string AttributeName => "Author";
    }
}