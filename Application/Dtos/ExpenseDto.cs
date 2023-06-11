namespace Application;

public class ExpenseDto
{
    public int Id { get; set; }
    public bool Separeted { get; set; }
    public bool Inactive { get; set; }
    public DateTime DateLastInstallments { get; set; }
    public DateTime DateFirstInstallments { get; set; }
    public decimal Amount { get; set; }
    public int CountInstallments { get; set; }
    public string Describe { get; set; }
    public string ExpenseName { get; set; }
    public string PaymentType { get; set; }
    public decimal TotalExpensesItem { get; set; }
    public decimal TotalExpensesItemRemaining { get; set; }
    public int PayedInstallments { get; set; }
    public int RemainingInstallments { get; set; }

    // relational maps
    public int IdBank { get; set; }
    public List<PaidInstallmentsDto> paidInstallments { get; set; }
}