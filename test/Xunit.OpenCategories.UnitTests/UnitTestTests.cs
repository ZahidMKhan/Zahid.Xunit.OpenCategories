using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class UnitTestTests
{
    [Fact]
    [UnitTest]
    public void UnitTest()
    {
        var testMethod = typeof(UnitTestTests).GetMethod(nameof(UnitTest));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<UnitTestAttribute>();
    }
        
    [Fact]
    [UnitTest("UnitTestName")]
    public void UnitTest_String()
    {
        var testMethod = typeof(UnitTestTests).GetMethod(nameof(UnitTest_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<UnitTestAttribute>()
            .Which.Identifier.Should().Be("UnitTestName");
    }
        
    [Fact]
    [UnitTest(999)]
    public void UnitTest_Long()
    {
        var testMethod = typeof(UnitTestTests).GetMethod(nameof(UnitTest_Long));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<UnitTestAttribute>()
            .Which.Identifier.Should().Be("999");
    }
}