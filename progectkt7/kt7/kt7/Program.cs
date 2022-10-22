struct Student {
    public string name;
    public string surname;
    public int age;
    public int studycourse;
    public int recordbook;
    public string formtraining;

    public void Display()
    {
        Console.WriteLine($"Имя: {name}", "Фамилия: {surname}", "Возраст: {age}", "Курс обучения: {studycourse}", "Номер зачетной книги: {recordbook}", "Форма обучения: {formtraining}");
    }
    public void Info()
    {
        name = "Ангелина";
        surname = "Калинина";
        age = 20;
        studycourse = 1;
        recordbook = 2284451;
        formtraining = "Очная";

    }
    public void Create()
    {
        Console.WriteLine("Введите имя");
        name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите фамилию");
        surname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите возраст");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите курс обучения");
        studycourse = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер зачетной книжки");
        recordbook = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите форму обучения");
        formtraining = Convert.ToString(Console.ReadLine());

    }
}
class Menu
{
    static void Menu()
    {
        Console.WriteLine("1. Добавить нового студента в группу");
        Console.WriteLine("2. Добавить нового студента в группу со стандартными значениями");
        Console.WriteLine("3. Просмотр списка группы");
        Console.WriteLine("4. Удаление студента из группы");
        Console.WriteLine("5. Выход");
    }

    static void Main(string[] args)
    {
        List<Student> allstudent = new List<Student>();
        string input;
        do
        {
            Console.WriteLine("Выберите пункт меню");
            Menu();
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Добавить нового студента в группу");
                Student student = new Student();
                student.Create();
                allstudent.Add(student);

            }
            else if (input == "2")
            {
                Console.WriteLine("Добавить нового студента в группу со стандартными значениями");
                Student student = new Student();
                student.Info();
                allstudent.Add(student);
            }
            else if(input =="3")
            {
                Console.WriteLine("Просмотр списка группы");
                foreach(var el in allstudent)
                {
                    el.Display();
                }
                    
            }
            else if(input=="4")
            {
                Console.WriteLine("Удаление студента из группы по номеру зачетной книжки");
                Console.WriteLine("Номер зачетной книжки студента, которого хотите удалить");
                int delete = Convert.ToInt32(Console.ReadLine());
                var i = 0;
                var deleteStudentIndex = -1;
                foreach (var el in allstudent)
                {
                    if (el.recordbook == delete)
                    {
                        deleteStudentIndex = i;
                        
                    }
                    i++;
                }
                if(deleteStudentIndex!=-1)
                {
                    allstudent.RemoveAt(deleteStudentIndex);
                }
                else
                {
                    Console.WriteLine("Не существует");
                }

                
            }
        }
        while (input != "5");
    }
    
}
