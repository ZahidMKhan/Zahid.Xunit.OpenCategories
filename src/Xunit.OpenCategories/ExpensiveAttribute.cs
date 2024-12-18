﻿using System;
using System.Collections.Generic;
using Xunit.v3;

namespace Xunit.OpenCategories
{
    /// <summary>
    /// Attribute to specify that a test is expensive in terms of resources or time.
    /// </summary>
    /// <remarks>
    /// This attribute can be applied to both classes and methods, and it supports multiple usages.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class ExpensiveAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc/>
        public IReadOnlyCollection<KeyValuePair<string, string>> GetTraits()
        {
            return new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Category", "Expensive")
            };
        }
    }
}