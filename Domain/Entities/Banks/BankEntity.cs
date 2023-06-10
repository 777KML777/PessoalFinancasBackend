namespace Domain
{
    public class BankEntity : Entity
    {

        private IList<ExpensesEntity> _expenses;
        public BankEntity () 
        {
            // Quando conectar com o banco, provavelmente irá precisar instanciar o Expenses.

        }
        
        public decimal Balance { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyCollection<ExpensesEntity> Expenses { get {return _expenses.ToArray(); }}

        public void AddExpensesToBanks(ExpensesEntity expenses) => 
            _expenses.Add(expenses);
        
    }

}
