using leetcode_answers;
using NUnit.Framework;
namespace LeetcodeTests
{
    public class ArraysAndStringsTests
    {
        public ArraysandStringsAnswers answer = new ArraysandStringsAnswers();

        [Test]
        public void RemoveElementTests()
        {
            int[] nums1 = [3, 2, 2, 3];
            int val1 = 3;
            int[] nums2 = [0, 1, 2, 2, 3, 0, 4, 2];
            int val2 = 2;

            int result1 = answer.RemoveElement(nums1, val1);
            Assert.That(result1, Is.EqualTo(2));
            int result2 = answer.RemoveElement(nums2, val2);
            Assert.That(result2, Is.EqualTo(5));

        }

        [Test]
        public void MaxProfitTests()
        {
            int[] prices1 = [7, 1, 5, 3, 6, 4];
            int[] prices2 = [7, 6, 4, 3, 1];

            Assert.That(answer.MaxProfit(prices1), Is.EqualTo(5));
            Assert.That(answer.MaxProfit(prices2), Is.EqualTo(0));
        }
        [Test]
        public void TestLengthOfLastWord()
        {
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";
            string s3 = "s";
            Assert.That(answer.LengthOfLastWord(s1), Is.EqualTo(5));
            Assert.That(answer.LengthOfLastWord(s2), Is.EqualTo(4));
            Assert.That(answer.LengthOfLastWord(s3), Is.EqualTo(1));

        }
    }
}