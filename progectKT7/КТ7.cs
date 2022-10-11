
struct Student
{
public string name;
public int age;
public string surname;
public int coursestudy;
public int recordbook;
public string formtraining;
public void Show()
{
  Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Курсе обучения: {coursestudy} Номере зачетной книжки: {recordbook} Форме обучения: {formtraining}")
}
public void InputInfo() {
        name = "Ангелина";
        surname = "Калинина";
        age = 20;
        coursestudy = 1;
        recordbook = 2284411;
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
        coursestudy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер зачетной книжки");
        recordbook = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите форму обучения");
        formtraining = Convert.ToString(Console.ReadLine());

    }

List<string> people = new List<string>();

class Program
{
 public void Menu()  
 { string answer="0";
  Console.WriteLine("Выберите пункт меню");
  Console.WriteLine("1)Добавьте студента");
  Console.WriteLine("2)Удалить студента по номеру зачетной книжки");
  Console.WriteLine("3)Ввести в список всех студентов");
  Console.WriteLine("0)Выход");
  answer=Console.ReadLine();
  if (answer=="1"){}
  else if (answer=="2"){}
  else if (answer=="3"){}
  if(answer!="0"){Menu}
 }
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
                Console.WriteLine("Вы выбрали (Добавить нового студента в группу)");
                Student student = new Student();
                student.Create();
                allstudent.Add(student);

            }
            else if (input == "2")
            {
                Console.WriteLine("Вы выбрали(Добавить нового студента в группу со стандартными значениями)");
                Student student = new Student();
                student.InputInfo();
                allstudent.Add(student);
            }
            else if(input =="3")
            {
                Console.WriteLine("Вы выбрали (Просмотр списка группы)");
                foreach(var el in allstudent)
                {
                    el.Show();
                }
                    
            }
            else if(input=="4")
            {
                Console.WriteLine("Вы выбрали (Удаление студента из группы по номеру зачетной книжки)");
                Console.WriteLine("напишите номер зачетной книжки студента, которого хотите удалить");
                int delete = Convert.ToInt32(Console.ReadLine());
                var i = 0;
                var deleteStudentIndex = -999;
                foreach (var el in allstudent)
                {
                    if (el.recordbook == delete)
                    {
                        deleteStudentIndex = i;
                        
                    }
                    i++;
                }
                if(deleteStudentIndex!=-999)
                {
                    allstudent.RemoveAt(deleteStudentIndex);
                }
                else
                {
                    Console.WriteLine("Такого студента не существует");
                }

                
            }
        }
        while (input != "5");
    }
    
}