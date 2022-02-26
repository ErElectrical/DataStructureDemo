using System;

namespace ParentheisAnalysis
{
    public class Program
    {
        static void Main()
        {
            stack s = new stack();
            char[] arr = { '8', '*', '9', '(', '1', '+', '6', ')' };
            StackUsingArray sa = new StackUsingArray();
            sa.ParenthesisMatch(s, arr);

            char[] arrm = {'[', '8', '*', '9',']', '(', '1', '+', '6', ')' };
            sa.MultipleParentheisMatching(s, arrm);

        }
    }
}
