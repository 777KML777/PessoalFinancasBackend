namespace Application; 

public class BankDto 
{
    public int Id { get;  set; }
    public string BankName { get; set; }
    public decimal Balance { get; set; }
    public List<ExpenseDto> Expenses { get; set; }
}