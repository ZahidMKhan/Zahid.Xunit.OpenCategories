using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests;

public class SnapshotTestTests
{
    [Fact]
    [SnapshotTest]
    public void SnapshotTest()
    {
        var testMethod = typeof(SnapshotTestTests).GetMethod(nameof(SnapshotTest));
        testMethod.Should()
            .BeDecoratedWith<FactAttribute>()
            .And.BeDecoratedWith<SnapshotTestAttribute>();
    }
}