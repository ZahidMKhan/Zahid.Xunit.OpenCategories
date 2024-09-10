﻿using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class WorkItemsTests
{
    [Fact]
    [WorkItem]
    public void WorkItem()
    {
        var testMethod = typeof(WorkItemsTests).GetMethod(nameof(WorkItem));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<WorkItemAttribute>();
    }

    [Fact]
    [WorkItem(666)]
    public void WorkItem_Integer()
    {
        var testMethod = typeof(WorkItemsTests).GetMethod(nameof(WorkItem_Integer));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<WorkItemAttribute>()
            .Which.WorkItemId.Should().Be("666");
    }

    [Fact]
    [WorkItem("666 a")]
    public void WorkItem_String()
    {
        var testMethod = typeof(WorkItemsTests).GetMethod(nameof(WorkItem_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<WorkItemAttribute>()
            .Which.WorkItemId.Should().Be("666 a");
    }
}