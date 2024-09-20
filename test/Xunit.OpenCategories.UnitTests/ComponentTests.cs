using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class ComponentTests
{
    [Fact]
    [Component]
    public void Component()
    {
        var testMethod = typeof(ComponentTests).GetMethod(nameof(Component));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<ComponentAttribute>();
    }
    [Fact]
    [Component("Service X")]
    public void ComponentWithName()
    {
        var testMethod = typeof(ComponentTests).GetMethod(nameof(ComponentWithName));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<ComponentAttribute>()
            .Which.ComponentName.Should().Be("Service X");
    }
}