using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class ExpensiveTests
{
    [Fact]
    [Expensive]
    public void Expensive()
    {
        var testMethod = typeof(ExpensiveTests).GetMethod(nameof(Expensive));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<ExpensiveAttribute>();
    }
}