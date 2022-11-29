using System.Diagnostics.CodeAnalysis;

namespace Module.Tests;

/// <summary>
/// This is an example file that shows how code coverage metrics
/// are a bit bogus. They don't necessarily track the proper code
/// coverage. The two methods in StringUtility do the same thing
/// but one is more terse than the other, but the terse method
/// shows 100% coverage whereas the longer method shows 80%.
/// </summary>
[ExcludeFromCodeCoverage]
public class StringUtilityTests
{
    private StringUtility _unitUnderTest = new();
    
    [SetUp]
    public void Setup()
    {
        this._unitUnderTest = new StringUtility();
    }

    public class IsStringLongV1 : StringUtilityTests
    {
        [Test]
        public void IfStringIsLessThanFiveCharacters_ReturnsFalse()
        {
            var actual = base._unitUnderTest.IsLongStringV1("abc");
            
            Assert.That(actual, Is.False);
        }
    }

    public class IsStringLongV2 : StringUtilityTests
    {
        [Test]
        public void IfStringIsLessThanFiveCharacters_ReturnsFalse()
        {
            var actual = base._unitUnderTest.IsLongStringV2("abc");
            
            Assert.That(actual, Is.False);
        }
    }
}