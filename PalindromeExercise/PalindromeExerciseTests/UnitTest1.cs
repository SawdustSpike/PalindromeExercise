using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Michael", false)]

        public void IsAPalindrome_Test(String pal, bool expected)
        {
            var c = new WordSmith();
            var actual = c.IsAPalindrome(pal);
            Assert.Equal(expected, actual);
        }
        

        
    }
}
