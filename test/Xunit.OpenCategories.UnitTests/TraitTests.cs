using FluentAssertions;

namespace Xunit.OpenCategories.UnitTests
{
    public class TraitTests
    {
        [Fact]
        public void Test()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Test));
            testMethod.Should().BeDecoratedWith<FactAttribute>();
        }

        [Fact]
        [DatabaseTest]
        public void DatabaseTest()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(DatabaseTest));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<DatabaseTestAttribute>();
        }

        [Fact]
        [SnapshotTest]
        public void SnapshotTest()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(SnapshotTest));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SnapshotTestAttribute>();
        }

        [Fact]
        [Expensive]
        public void Expensive()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Expensive));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<ExpensiveAttribute>();
        }

        [Fact]
        [Bug]
        public void Bug()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Bug));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<BugAttribute>();
        }

        [Fact]
        [Bug(777)]
        public void BugWithId_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(BugWithId_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<BugAttribute>()
                .Which.Id.Should().Be("777");
        }

        [Fact]
        [Bug("777")]
        public void BugWithId_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(BugWithId_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<BugAttribute>()
                .Which.Id.Should().Be("777");
        }
        
        [Fact]
        [Feature]
        public void Feature()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Feature));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<FeatureAttribute>();
        }

        [Fact, IntegrationTest]
        [Feature(888)]
        public void FeatureWithId_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(FeatureWithId_Integer));
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
            var testMethod = typeof(TraitTests).GetMethod(nameof(FeatureWithId_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<IntegrationTestAttribute>()
                .And.BeDecoratedWith<FeatureAttribute>()
                .Which.Identifier.Should().Be("888");
        }

        [Fact]
        [KnownBug]
        public void KnownBug()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(KnownBug));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<KnownBugAttribute>();
        }

        [Fact]
        [KnownBug(666)]
        public void KnownBugWithId_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(KnownBugWithId_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<KnownBugAttribute>()
                .Which.Id.Should().Be("666");
        }

        [Fact]
        [KnownBug("666 a")]
        public void KnownBugWithId_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(KnownBugWithId_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<KnownBugAttribute>()
                .Which.Id.Should().Be("666 a");
        }
        
        [Fact]
        [Documentation]
        public void Documentation()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Documentation));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<DocumentationAttribute>();
        }

        [Fact]
        [Documentation(666)]
        public void Documentation_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Documentation_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<DocumentationAttribute>()
                .Which.WorkItemId.Should().Be("666");
        }

        [Fact]
        [Documentation("666 a")]
        public void Documentation_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Documentation_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<DocumentationAttribute>()
                .Which.WorkItemId.Should().Be("666 a");
        }
        
        [Fact]
        [Exploratory]
        public void Exploratory()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Exploratory));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<ExploratoryAttribute>();
        }

        [Fact]
        [Exploratory(666)]
        public void Exploratory_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Exploratory_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<ExploratoryAttribute>()
                .Which.WorkItemId.Should().Be("666");
        }

        [Fact]
        [Exploratory("666 a")]
        public void Exploratory_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Exploratory_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<ExploratoryAttribute>()
                .Which.WorkItemId.Should().Be("666 a");
        }
        
        [Fact]
        [WorkItem]
        public void WorkItem()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(WorkItem));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<WorkItemAttribute>();
        }

        [Fact]
        [WorkItem(666)]
        public void WorkItem_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(WorkItem_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<WorkItemAttribute>()
                .Which.WorkItemId.Should().Be("666");
        }

        [Fact]
        [WorkItem("666 a")]
        public void WorkItem_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(WorkItem_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<WorkItemAttribute>()
                .Which.WorkItemId.Should().Be("666 a");
        }
        
        [Fact]
        [SystemTest]
        public void SystemTest()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(SystemTest));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SystemTestAttribute>();
        }

        [Fact]
        [SystemTest(666)]
        public void SystemTest_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(SystemTest_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SystemTestAttribute>()
                .Which.Id.Should().Be("666");
        }

        [Fact]
        [SystemTest("666 a")]
        public void SystemTest_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(SystemTest_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SystemTestAttribute>()
                .Which.Id.Should().Be("666 a");
        }
        
        [Fact]
        [TestCase]
        public void TestCase()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(TestCase));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<TestCaseAttribute>();
        }

        [Fact]
        [TestCase(999)]
        public void TestCase_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(TestCase_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<TestCaseAttribute>()
                .Which.TestCaseId.Should().Be("999");
        }

        [Fact]
        [TestCase("999")]
        public void TestCase_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(TestCase_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<TestCaseAttribute>()
                .Which.TestCaseId.Should().Be("999");
        }
        
        [Fact]
        [LocalTest]
        public void LocalTest()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(LocalTest));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<LocalTestAttribute>();
        }

        [Fact]
        [LocalTest(666)]
        public void LocalTest_Integer()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(LocalTest_Integer));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<LocalTestAttribute>()
                .Which.Id.Should().Be("666");
        }

        [Fact]
        [LocalTest("666 a")]
        public void LocalTest_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(LocalTest_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<LocalTestAttribute>()
                .Which.Id.Should().Be("666 a");
        }

        [Fact]
        [Author("Henry David Thoreau")]
        public void Author()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Author));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<AuthorAttribute>()
                .Which.AuthorName.Should().Be("Henry David Thoreau");
        }

        [Fact]
        [Description("All your base are belong to us")]
        public void Description()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Description));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<DescriptionAttribute>()
                .Which.Description.Should().Be("All your base are belong to us");
        }
        
        [Fact]
        [Category("CategoryName")]
        public void Category_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Category_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<CategoryAttribute>()
                .Which.Name.Should().Be("CategoryName");
        }
        
        [Fact]
        [Specification]
        public void Specification()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Specification));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SpecificationAttribute>();
        }
        
        [Fact]
        [Specification("SpecificationName")]
        public void Specification_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Specification_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SpecificationAttribute>()
                .Which.Identifier.Should().Be("SpecificationName");
        }
        
        [Fact]
        [Specification(999)]
        public void Specification_Long()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(Specification_Long));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<SpecificationAttribute>()
                .Which.Identifier.Should().Be("999");
        }
        
        [Fact]
        [UnitTest]
        public void UnitTest()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UnitTest));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UnitTestAttribute>();
        }
        
        [Fact]
        [UnitTest("UnitTestName")]
        public void UnitTest_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UnitTest_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UnitTestAttribute>()
                .Which.Identifier.Should().Be("UnitTestName");
        }
        
        [Fact]
        [UnitTest(999)]
        public void UnitTest_Long()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UnitTest_Long));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UnitTestAttribute>()
                .Which.Identifier.Should().Be("999");
        }
        
        [Fact]
        [UserStory]
        public void UserStory()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UserStory));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UserStoryAttribute>();
        }
        
        [Fact]
        [UserStory("UserStoryName")]
        public void UserStory_String()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UserStory_String));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UserStoryAttribute>()
                .Which.Identifier.Should().Be("UserStoryName");
        }
        
        [Fact]
        [UserStory(999)]
        public void UserStory_Long()
        {
            var testMethod = typeof(TraitTests).GetMethod(nameof(UserStory_Long));
            testMethod.Should()
                .BeDecoratedWith<FactAttribute>()
                .And.BeDecoratedWith<UserStoryAttribute>()
                .Which.Identifier.Should().Be("999");
        }
    }
}