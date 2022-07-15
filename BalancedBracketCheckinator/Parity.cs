using System;

namespace BalancedBracketCheckinatorNS
{
    public class Parity
    {
        public static bool checkBracketParity(string testString)
        {
            const char CLOSING_BRACKET = '}';
            const char OPENING_BRACKET = '{';
            Stack<string> stack = new Stack<string>();

            foreach (char value in testString.ToCharArray())
            {
                if (value.Equals(OPENING_BRACKET))
                {
                    stack.Push(value.ToString());
                }
                else if (value.Equals(CLOSING_BRACKET))
                {
                    if (stack.Count > 0)
                    {
                        string removed = stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return (stack.Count == 0);
        }

        public static void Main()
        {
            bool result = Parity.checkBracketParity("test");
        }
    }

}
