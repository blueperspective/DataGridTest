using System.Collections.Generic;
using System.Linq;

namespace DataGridTest.Model;
internal class Enricher
{
    public void Enrich(IEnumerable<TransactionVM> transactions, IEnumerable<Payee> payees, IEnumerable<Category> categories)
    {
        int i = 0;
        int payeeCount = payees.Count();
        int categoryCount = categories.Count();

        foreach (var transaction in transactions)
        {
            transaction.Payee = payees.ElementAt(i % payeeCount);
            transaction.Category = categories.ElementAt(i % categoryCount);

            i++;
        }
    }
}
