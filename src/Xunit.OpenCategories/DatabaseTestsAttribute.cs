﻿using System;
using System.Collections.Generic;

namespace Xunit.OpenCategories;

/// <summary>
/// Attribute to specify that a test class or method is related to database testing.
/// </summary>
/// <remarks>
/// This attribute can be applied to both classes and methods, and it supports multiple usages.
/// </remarks>
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class DatabaseTestsAttribute : BaseAttribute
{
    /// <inheritdoc />
    protected override void MandatoryTraits(List<KeyValuePair<string, string>> traits)
    {
        traits.Add(new KeyValuePair<string, string>("Category", "DatabaseTest"));
    }
}