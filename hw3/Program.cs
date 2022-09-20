//1

struct Atricle
{
    int Code;
    string Name;
    int Price;
    ArticleType Type;
}

struct Client
{
    string Name;
    string Surname;
    string Fathersname;
    string Adress;
    int Phone;
    int NumberOfOrders;
    ClientType Type;
}

struct RequestItem
{
    string Item;
    int NumberOfItems;
}

struct Request
{
    int code;
    string Client;
    DateTime Date;
    string Items;
    double summ;
    PayType Type;
}

enum ArticleType
{
    Goods = 1,
    Transport,
    Health,
    Gifts,
    Other,
}

enum ClientType
{
    Low = 1,
    High,
    Vip,
}

enum PayType
{
    cash = 1,
    creditCard,
    debitCard,
    other,
}

//8

class Student
{
    protected string StudentName;
    public string studentname
    {
        get { return StudentName; }
        set { StudentName = value; }
    }
    protected string StudentSurname;
    public string studentsurname
    {
        get { return StudentSurname; }
        set { StudentSurname = value; }
    }
    protected string StudentFathersname;
    public string studentfathersname
    {
        get { return StudentFathersname; }
        set { StudentFathersname = value; }
    }
    protected string StudentGroup;
    public string studentgroup
    {
        get { return StudentGroup; }
        set { StudentGroup = value; }
    }
    protected int StudentAge;
    protected int[][] marks = new int[3][] { new int[0], new int[0], new int[0]}; 
    public void marks_pro(int n) 
    {
        int[] tmp = new int[marks[0].Length+1];
        for(int i = 0; i < tmp.Length-1; i++)
        {
            tmp[i] = marks[0][i];
        }
        tmp[tmp.Length - 1] = n;
        for(int i = 0; i < tmp.Length; i++)
        {
            marks[0][i] = tmp[i];
        }
    }
    public void marks_adm(int n)
    {
        int[] tmp = new int[marks[1].Length + 1];
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = marks[1][i];
        }
        tmp[tmp.Length - 1] = n;
        for (int i = 0; i < tmp.Length; i++)
        {
            marks[1][i] = tmp[i];
        }
    }
    public void marks_des(int n)
    {
        int[] tmp = new int[marks[2].Length + 1];
        for (int i = 0; i < tmp.Length - 1; i++)
        {
            tmp[i] = marks[2][i];
        }
        tmp[tmp.Length - 1] = n;
        for (int i = 0; i < tmp.Length; i++)
        {
            marks[2][i] = tmp[i];
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name:\t\t" + StudentName);
        Console.WriteLine($"Surname:\t" + StudentSurname);
        Console.WriteLine($"Fathersname:\t" + StudentFathersname);
        Console.WriteLine($"Group:\t" + StudentGroup);
        Console.WriteLine($"Age:\t\t" + StudentAge);
        Console.WriteLine("\t\tMarks");
        Console.WriteLine("Programming: ");
        for(int i= 0; i < marks[0].Length; i++)
        {
            Console.WriteLine(marks[0][i]);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Administration: ");
        for (int i = 0; i < marks[1].Length; i++)
        {
            Console.WriteLine(marks[1][i]);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Design: ");
        for (int i = 0; i < marks[2].Length; i++)
        {
            Console.WriteLine(marks[2][i]);
        }
        Console.WriteLine("--------------------------");
    }
}