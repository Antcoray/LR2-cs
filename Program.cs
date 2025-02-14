// Условие задания:какая из цифр трехзначного числа больше: первая или последняя
// Чтобы запустить тестовый режим введите 1809
using LR2_C_;

class Task_1
{
    public static string CorrectInput()
    {
        bool IsCorrect = false;
        string Input = "defaultValue";
        Console.WriteLine("Введите трехзначное число");
        while (!IsCorrect)
        {
            IsCorrect = true;
            Input = Console.ReadLine();

            if (!int.TryParse(Input, out _))
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку");
                IsCorrect = false;
            }
            if (Input.Length != 3)
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку");
                IsCorrect = false;
            }
            if (Input == "1809")
            {
                return Input;
            }
        }
        return Input;
    }
    public static void Main()
    {
        string[] tests = { "180", "394", "505", "104",
                           "217", "325", "438", "509",
                           "612", "723", "834", "945",
                           "156", "267", "378", "489",
                           "590", "601", "712", "823",
                           "934", "105", "216", "999" };
        bool testing = false;
        int TestingIterator = 0;
        int index = 0;
        string Input = "defaultValue";
        while (true)
        {
            if (!testing)
            {
                Input = CorrectInput();
            }
            if (Input == "1809")
            {
                testing = true;
                TestingIterator = 0;
            }
            if (testing == true)
            {
                Input = tests[TestingIterator++];
                if (TestingIterator >= tests.Length)
                {
                    TestingIterator = 0;
                    testing = false;
                }
            }

            if (Input[0] > Input[2])
            {
                index = 0;
            }
            if (Input[0] < Input[2])
            {
                index = 1;
            }
            if (Input[0] == Input[2])
            {
                index = 2;
            }
            int var = Menu.MenuMethod(Input, index);
            if (var == 1)
            {
                return;
            }
        }
    }
}