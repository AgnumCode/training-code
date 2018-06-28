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
            // if we reach her, the test is successful
            
        }

        [Fact]
        public void DumbLongestShouldReturnLongest()
        {
            // arrange 
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "ab", "abc", "abc", "Nick Escalone", "12345"
            };
            col.AddMany(items);
            var expected = "Nick Escalone";

            // act
            var actual = col.DumbLongest();

            
            // assert
            Assert.Equal(expected, actual);



        }
    }
}
