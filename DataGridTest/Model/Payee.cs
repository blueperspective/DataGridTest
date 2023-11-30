namespace DataGridTest.Model;
public class Payee
{
    public Payee(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
