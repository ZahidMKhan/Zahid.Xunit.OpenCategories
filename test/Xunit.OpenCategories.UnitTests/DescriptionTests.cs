using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class DescriptionTests
{
    [Fact]
    [Description("All your base are belong to us")]
    public void Description()
    {
        var testMethod = typeof(DescriptionTests).GetMethod(nameof(Description));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<DescriptionAttribute>()
            .Which.Description.Should().Be("All your base are belong to us");
    }
}