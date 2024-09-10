using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class DatabaseTestTests
{
    [Fact]
    [DatabaseTest]
    public void DatabaseTest()
    {
        var testMethod = typeof(DatabaseTestTests).GetMethod(nameof(DatabaseTest));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<DatabaseTestAttribute>();
    }
}