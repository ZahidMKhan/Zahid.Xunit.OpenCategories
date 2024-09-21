﻿using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class LocalTestAttributeTests
{
    [Fact]
    [LocalTest]
    public void LocalTest()
    {
        var testMethod = typeof(LocalTestAttributeTests).GetMethod(nameof(LocalTest));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<LocalTestAttribute>();
    }

    [Fact]
    [LocalTest(666)]
    public void LocalTest_Integer()
    {
        var testMethod = typeof(LocalTestAttributeTests).GetMethod(nameof(LocalTest_Integer));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<LocalTestAttribute>()
            .Which.Id.Should().Be("666");
    }

    [Fact]
    [LocalTest("666 a")]
    public void LocalTest_String()
    {
        var testMethod = typeof(LocalTestAttributeTests).GetMethod(nameof(LocalTest_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<LocalTestAttribute>()
            .Which.Id.Should().Be("666 a");
    }
}