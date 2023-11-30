using DataGridTest.Model;

namespace DataGridTest.ViewModels;
internal class TransformationVM
{
    public TransformationVM(string regex, Payee payee, Category category)
    {
        Regex = regex;
        Payee = payee;
        Category = category;
    }

    public string Regex { get; set; }

    public Payee Payee { get; set; }

    public Category Category { get; set; }
}
