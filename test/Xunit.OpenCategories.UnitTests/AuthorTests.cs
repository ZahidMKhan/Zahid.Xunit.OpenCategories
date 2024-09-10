using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class AuthorTests
{
    [Fact]
    [Author("Henry David Thoreau")]
    public void Author()
    {
        var testMethod = typeof(AuthorTests).GetMethod(nameof(Author));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<AuthorAttribute>()
            .Which.AuthorName.Should().Be("Henry David Thoreau");
    }
}