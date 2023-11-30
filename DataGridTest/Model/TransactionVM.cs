using ReactiveUI;
using System;

namespace DataGridTest.Model;
public class TransactionVM : ReactiveObject
{
    public TransactionVM(DateTime date, string obj, decimal amount)
    {
        this.Date = date;
        this.Object = obj;
        this.Amount = amount;
    }

    private DateTime date;

    public DateTime Date
    {
        get => date;
        set => this.RaiseAndSetIfChanged(ref date, value);
    }

    private string obj = string.Empty;

    public string Object
    {
        get => obj;
        set => this.RaiseAndSetIfChanged(ref obj, value);
    }

    private decimal amount;

    public decimal Amount
    {
        get => amount;
        set => this.RaiseAndSetIfChanged(ref amount, value);
    }

    private Category? category;

    public Category? Category
    {
        get => category;
        set => this.RaiseAndSetIfChanged(ref category, value);
    }

    private Payee? payee;

    public Payee? Payee
    {
        get => payee;
        set => this.RaiseAndSetIfChanged(ref payee, value);
    }
}
