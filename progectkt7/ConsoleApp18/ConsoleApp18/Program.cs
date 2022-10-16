public class Human
{
    protected string surname;
    protected string name;
    protected bool sex;
    public Human(string _name, string _surname, bool _sex)
    {
        this.name = _name;
        this.surname = _surname;
        this.sex = _sex;
    }
    public string Name { get { return name; } set { name = value; } }
    public string Surname { get { return surname; } set { surname = value; } }
    public bool Sex { get { return sex; } set { sex = value; } }
    public void Print()
    {
        Console.WriteLine("name: {0}", name);
        Console.WriteLine("surname: {0}", surname);
        if (sex==true)
            Console.WriteLine("sex: Female");
        else
            Console.WriteLine("sex: Male");

    }   
}
namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)

        {
            Human hm = new Human("Michele", "Jakson", false);
            hm.Print();
            Citizen ct = new Citizen("Mario", "Chel", false, "propose111222", "Rostov-on-Don");
            Console.WriteLine("------------------------");
            ct.Print();     
            ForeignCitizen fc = new ForeignCitizen("Mile", "Jonson", false, "0230902ADK", "Ottawa", "023329032JJK", Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));
            Console.WriteLine("------------------------");
            fc.Print();
        }

    }
}

    

