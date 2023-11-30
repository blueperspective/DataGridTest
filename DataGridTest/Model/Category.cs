namespace DataGridTest.Model;
public class Category
{
    public Category(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
