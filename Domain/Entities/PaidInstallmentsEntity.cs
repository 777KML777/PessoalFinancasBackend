namespace Domain; 

public class PaidInstallmentsEntity 
{
    public PaidInstallmentsEntity()
        {

        }

        public DateTime PaymentDate { get; set; }
        
        // Relational 
        public int IdExpenses { get; private set; }
        public ExpensesEntity Expenses { get; set; }
}