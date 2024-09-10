using Xunit.OpenCategories.Discoverers;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="UserStoryAttribute"/>.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class UserStoryDiscoverer : TraitWithStringDiscoverer<UserStoryDiscoverer>
    {
        /// <inheritdoc />
        protected override string NamedArgumentName => "Identifier";
        
        /// <inheritdoc />
        protected override string AttributeName => "UserStory";
    }
}