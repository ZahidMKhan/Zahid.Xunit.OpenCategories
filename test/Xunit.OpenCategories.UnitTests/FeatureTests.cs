using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class FeatureTests
{
    [Fact]
    [Feature]
    public void Feature()
    {
        var testMethod = typeof(FeatureTests).GetMethod(nameof(Feature));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<FeatureAttribute>();
    }

    [Fact, IntegrationTest]
    [Feature(888)]
    public void FeatureWithId_Integer()
    {
        var testMethod = typeof(FeatureTests).GetMethod(nameof(FeatureWithId_Integer));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<IntegrationTestAttribute>()
            .And.BeDecoratedWith<FeatureAttribute>()
            .Which.Identifier.Should().Be("888");
    }

    [Fact, IntegrationTest]
    [Feature("888")]
    public void FeatureWithId_String()
    {
        var testMethod = typeof(FeatureTests).GetMethod(nameof(FeatureWithId_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<IntegrationTestAttribute>()
            .And.BeDecoratedWith<FeatureAttribute>()
            .Which.Identifier.Should().Be("888");
    }
}