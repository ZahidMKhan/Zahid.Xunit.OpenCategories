namespace Xunit.OpenCategories.Discoverers
{
    /// <summary>
    /// Abstract base class for trait discoverers.
    /// </summary>
    /// <typeparam name="TDiscoverer">The type of the discoverer.</typeparam>
    public abstract class BaseTraitDiscoverer<TDiscoverer>
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(TDiscoverer);

        /// <summary>
        /// Gets the name of the attribute associated with the discoverer.
        /// </summary>
        protected abstract string AttributeName { get; }
    }
}