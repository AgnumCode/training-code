using LINQDemo.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectLINQDemo.Testing
{
    public class NonGenericCollectionsTest
    {
        [Fact]
        public void AddShouldNotThrowException()
        {
            // arrange 
            var col = new NonGenericCollection();

            // act
            col.Add("test string");

            // assert
            // if we reach here, the test is successful

        }

        // theory adds different sets of parameters
        [Theory]
        [InlineData("1234", new string[] { "12", "1234" })]
        [InlineData(null, new string[] { })]
        [InlineData("asdas", new string[] { "12", "1234", "asdas" })]
        public void DumbLongestShouldReturnLongest(
            string expected, string[] data)
        {
            // Arrange 
            var col = new NonGenericCollection();
            col.AddMany(data);

            //var expected = "Nick Escalone";                       // not needed for Theory

            // Act
            var actual = col.DumbLongest();


            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new string[] { "asdf" } };
            yield return new object[] { new string[] { "asdf", "asdfas" } };
            yield return new object[] { new string[] { } };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void AddManyShouldNotThrowException(string[] data)
        {
            var col = new NonGenericCollection();
            col.AddMany(data);
            // if no exception thrown than sucess

        }

        // sort 3rd element from list when sorted alphabetically
        [Fact]
        public void ThirdAlphabeticalShouldReturnParameter()
        {
            // Arrange 
            var col = new NonGenericCollection();
            var items = new List<string>
                {
                    "a", "ab", "abc", "Nick Escalone", "12345"
                };
            col.AddMany(items);
            var expected = "ab";

            // Act
            var actual = col.ThirdAlphabetical();

            // Assert
            Assert.Equal(expected, actual);

        }

        // test the extension method
        [Fact]
        public void ExtensionMethodIsEmptyShouldSayEmpty()
        {
            var col = new NonGenericCollection();
            Assert.True(col.IsEmpty());

        }

        [Fact]
        public void ContainsShouldThrowExceptionForNull()
        {
            var col = new NonGenericCollection();
            Assert.Throws<ArgumentNullException>(
                "item", () => col.Contains(null));
        }
    }
}

        
        
    

