namespace RegexProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RegexProblem regexProblem = new RegexProblem();
            //UC1
            regexProblem.CheckFirstName("Rushi");

            ///UC2
            regexProblem.CheckLatName("Dharmadhikari");

            ///UC3
           
            regexProblem.CheckEmail("abc.xyz@bl.co.in");

            ///UC4
            regexProblem.CheckMobilNumber("91 8329806536");
            ///UC5
            regexProblem.CheckPassWord8Char("12345ccd");

            //UC6
            regexProblem.CheckPass8CharWithUpperCase("14baAcsds");

            //UC7
            regexProblem.CheckPasswordWithSingleNumber("Abcdefg1");
            regexProblem.CheckPasswordWithSingleNumber("Abcdefgh");

            //UC8
            regexProblem.CheckPasswordWithSpecialChar("123456@abcd");
        }
    }
}