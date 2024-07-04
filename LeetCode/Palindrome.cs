namespace LeetCode
{
    public class Palindrome
    {
        public static bool isPalindrome(int x)
        {
            string str = x.ToString();
            var strLen = str.Length;
            int counter = 0;
            int middle = strLen % 2 == 0 ? strLen / 2 : strLen / 2 + 1;
            
            while(counter <= middle && strLen != 1)
            {
                if (str[counter] != str[strLen - counter - 1]) return false;
                counter++;
            }
            return true;
        }
    }
}
