using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class TestCaseTests
{
    [Fact]
    [TestCase]
    public void TestCase()
    {
        var testMethod = typeof(TestCaseTests).GetMethod(nameof(TestCase));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<TestCaseAttribute>();
    }

    [Fact]
    [TestCase(999)]
    public void TestCase_Integer()
    {
        var testMethod = typeof(TestCaseTests).GetMethod(nameof(TestCase_Integer));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<TestCaseAttribute>()
            .Which.TestCaseId.Should().Be("999");
    }

    [Fact]
    [TestCase("999")]
    public void TestCase_String()
    {
        var testMethod = typeof(TestCaseTests).GetMethod(nameof(TestCase_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<TestCaseAttribute>()
            .Which.TestCaseId.Should().Be("999");
    }
}