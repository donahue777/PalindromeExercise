using PalindromeExercise;
using System;
using System.Linq;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("poop", true)]
        [InlineData("Lump", false)]
        [InlineData("Peep", true)]
        public void PalidromeTest(string val, bool expected)
        {
            WordSmith wordy = new WordSmith();

            bool actual = wordy.IsAPalindrome(val);

            Assert.Equal(expected, actual);
        }
    }
}
