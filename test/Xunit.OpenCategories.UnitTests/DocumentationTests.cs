using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class DocumentationTests
{
    [Fact]
    [Documentation]
    public void Documentation()
    {
        var testMethod = typeof(DocumentationTests).GetMethod(nameof(Documentation));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<DocumentationAttribute>();
    }

    [Fact]
    [Documentation(666)]
    public void Documentation_Integer()
    {
        var testMethod = typeof(DocumentationTests).GetMethod(nameof(Documentation_Integer));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<DocumentationAttribute>()
            .Which.WorkItemId.Should().Be("666");
    }

    [Fact]
    [Documentation("666 a")]
    public void Documentation_String()
    {
        var testMethod = typeof(DocumentationTests).GetMethod(nameof(Documentation_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<DocumentationAttribute>()
            .Which.WorkItemId.Should().Be("666 a");
    }
}