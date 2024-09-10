﻿using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Discovers the traits for the <see cref="WorkItemAttribute"/>.
    /// </summary>
    public class WorkItemDiscoverer : ITraitDiscoverer
    {
        /// <summary>
        /// The fully qualified type name of the discoverer.
        /// </summary>
        internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(WorkItemDiscoverer);

        /// <summary>
        /// Gets the traits for the specified trait attribute.
        /// </summary>
        /// <param name="traitAttribute">The trait attribute containing the work item information.</param>
        /// <returns>An enumerable of key-value pairs representing the traits.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            // Retrieve the "WorkItemId" named argument from the trait attribute
            var workItemId = traitAttribute.GetNamedArgument<string>("WorkItemId");

            // Yield a key-value pair representing the category as "WorkItem"
            yield return new KeyValuePair<string, string>("Category", "WorkItem");

            // If the WorkItemId is not null or whitespace, yield a key-value pair for the work item information
            if (!string.IsNullOrWhiteSpace(workItemId))
                yield return new KeyValuePair<string, string>("WorkItem", workItemId);
        }
    }
}