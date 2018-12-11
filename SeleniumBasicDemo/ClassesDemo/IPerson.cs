namespace ClassesDemo
{
    public interface IPerson
    {
        int Age { get; set; }

        string Name { get; set; }

        string FullName(string f, string l);
    }
}