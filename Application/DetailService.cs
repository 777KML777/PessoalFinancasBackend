namespace Application;

public class DetailService
{
    // private readonly IBankService _bankService;
    private readonly BankService _bankService;

    public DetailService ()
    {
        _bankService = new BankService();
        // _expensesService = new ExpensesService(); 
        // _paidInstallments = new PaidInstallmentsService();

    }
    public DetailDto GetAllDetails (int bankId)
    {
        DetailDto detail = new DetailDto();
        detail.Bank = _bankService.GetBankById(bankId);

        return detail;
    }
}
