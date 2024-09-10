# Xunit.OpenCategories
Friendlier attributes to help categorise your tests.

## History

This is a fork of the [Xunit.Categories](https://github.com/brendanconnolly/Xunit.Categories) project. The
excellent work of [Brendan Connolly - @bredanconnolly](https://github.com/brendanconnolly).

The project was not getting updated. I [reached out to Brendan](https://github.com/brendanconnolly/Xunit.Categories/issues/34)
and did not get a response. So in order to keep the project alive I forked it.

## Build Status

| Branch    | Status                                                                                                                                                                                                            |
|-----------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `master`  | [![master](https://github.com/baynezy/Xunit.OpenCategories/actions/workflows/branch-master.yml/badge.svg?branch=master)](https://github.com/baynezy/Xunit.OpenCategories/actions/workflows/branch-master.yml)     |
| `develop` | [![develop](https://github.com/baynezy/Xunit.OpenCategories/actions/workflows/branch-develop.yml/badge.svg?branch=develop)](https://github.com/baynezy/Xunit.OpenCategories/actions/workflows/branch-develop.yml) |
| `nuget`   | [![NuGet version](https://badge.fury.io/nu/Xunit.OpenCategories.svg)](http://badge.fury.io/nu/Xunit.OpenCategories)                                                                                               |

## Messy Traits?
The xUnit built in option *Traits* can get a little messy. Its just 2 strings representing a key and value, unless you are familiar with xUnit and the Trait attribute it looks a little magical.

Also both key and value must be specified on the command line. This means if you decorate your test with 
`[Trait("Category","Bug")]` you cannot run only tests from a specific bug  without adding another trait `([Trait("Bug","8675309"])`

## Friendly Attributes Included
- Author
- Bug
- Category
- Database Test
- Description
- Documentation
- Expensive
- Exploratory
- Feature
- Integration Test
- Known Bug
- Local Test
- Snapshot Test
- Specification
- System Test
- Test Case
- Unit Test
- User Story
- Work Item

Open an issue or pull request to add more.


## Example

``` csharp
[Fact]
[Bug]
public void TestBug()
{
    throw new NotImplementedException("I'm a bug");
}

[Fact]
[Bug("777")]
public void TestBugWithId()
{
    throw new NotImplementedException("I've got your number");
}

```

Using this attribute you get descriptive information and flexibility when running tests. 
You can run all tests marked as Bugs

``` bat
xunit.console.exe ... -trait "Category=Bug"

-or via dotnet test

dotnet test --filter "Category=Bug" 

```

or get more granular
``` bat
xunit.console.exe ... -trait "Bug=777"

-or via dotnet test
dotnet test --filter "Bug=777" 
```

## Documentation

[Library Documentation](https://baynezy.github.io/Xunit.OpenCategories/)