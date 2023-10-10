namespace StringBuilderTask
{
    internal class Program
    {
        //Task 1 
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle daxil edin: ");

            string input = Console.ReadLine().Trim();

            string newtext = FormatSpaces(FormatText(input));
            Console.WriteLine("Cumlenin yeni hali: "+newtext);

        }
        static string FormatText(string input)
        {
            StringBuilder sb = new StringBuilder();

            for(int i  = 0; i < input.Length; i++)
            {
                if (input[i] = ''  || i=0)
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }

        static string FormatText(string input)
        {
            char[] chars = input.ToCharArray();
            if(chars.Length > 0)
            {
                chars[0] = Char.ToUpper(chars[0]);
            }

            for (int i=1; i<chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }

            string formattext = new string(chars);
            return formattext;
        }
    }
}