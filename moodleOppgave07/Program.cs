namespace moodleOppgave07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("More please...");
            int number2 = Convert.ToInt32(Console.ReadLine());

            static int addOrMultiply(int num1, int num2)
            {
                if (num1 != num2)
                {
                    return num1 + num2;
                }
                else
                {
                    return num1 * num2;
                }
            }
            Console.WriteLine($"Sum: {addOrMultiply(number1, number2)}");
        }
    }
}