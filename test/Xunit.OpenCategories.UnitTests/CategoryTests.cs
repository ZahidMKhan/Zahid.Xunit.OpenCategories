using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class CategoryTests
{
    [Fact]
    [Category("CategoryName")]
    public void Category_String()
    {
        var testMethod = typeof(CategoryTests).GetMethod(nameof(Category_String));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<CategoryAttribute>()
            .Which.Name.Should().Be("CategoryName");
    }
}