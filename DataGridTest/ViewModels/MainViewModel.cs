using DataGridTest.Model;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace DataGridTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        for (int i = 0; i < 50; i++)
        {
            transactions.Add(new TransactionVM(DateTime.Today, $"obj{i}", new decimal(i)));
        }

        for (int i = 0; i < 10; i++)
        {
            categories.Add(new Category($"category {i}"));
        }

        for (int i = 0; i < 20; i++)
        {
            payees.Add(new Payee($"payee {i}"));
        }
    }

    public void Enrich()
    {
        var enricher = new Enricher();

        enricher.Enrich(transactions, payees, categories);
    }

    private ObservableCollection<TransactionVM> transactions = new();

    public ObservableCollection<TransactionVM> Transactions
    {
        get => transactions;
        set => this.RaiseAndSetIfChanged(ref transactions, value);
    }

    private ObservableCollection<Category> categories = new();

    public ObservableCollection<Category> Categories
    {
        get => categories;
        set => this.RaiseAndSetIfChanged(ref categories, value);
    }

    private ObservableCollection<Payee> payees = new();

    public ObservableCollection<Payee> Payees
    {
        get => payees;
        set => this.RaiseAndSetIfChanged(ref payees, value);
    }
}
