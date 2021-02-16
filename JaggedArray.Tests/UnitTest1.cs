using System;
using Xunit;

namespace JaggedArray.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[][] nums = new int[3][];
            nums[0] = new int[2] { 9, 5 };
            nums[1] = new int[3] { 4, 1, 0 };
            nums[2] = new int[3] { 8, 7, 6 };
            var result = JaggedArray.GetMaxValueFromRow(test);
            Assert.Equal( 12, result);
        }
    }
}
