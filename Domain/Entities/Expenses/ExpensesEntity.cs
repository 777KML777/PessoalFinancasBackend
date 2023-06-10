using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class ExpensesEntity : Entity
{
    private IList<PaidInstallmentsEntity> _paidInstallments;
    public ExpensesEntity()
    {
        _paidInstallments = new List<PaidInstallmentsEntity>();
        //AddPaymentsToInstallments();
    }

    public bool Separeted { get; private set; }
    public bool Inactive { get; private set; }
    public DateTime DateLastInstallments { get; private set; }
    public DateTime DateFirstInstallments { get; private set; }
    public decimal Amount { get; private set; }
    public int CountInstallments { get; private set; }
    public string Describe { get; private set; }
    public string ExpenseName { get; private set; }
    public string PaymentType { get; private set; }

    public IReadOnlyCollection<PaidInstallmentsEntity> PaidInstallments { get { return _paidInstallments.ToArray(); } }
    // Not Mapped Properties

    [NotMapped]
    public decimal TotalExpensesItem { get; private set; }
    [NotMapped]
    public decimal TotalExpensesItemRemaining { get; private set; }
    [NotMapped]
    public int PayedInstallments { get; private set; }
    [NotMapped]
    public int RemainingInstallments { get; private set; }

    // relational maps
    public int IdBank { get; private set; }
    public BankEntity Bank { get; set; }


    // Methods
    public void AddPaymentsToInstallments(PaidInstallmentsEntity PaidInstallments)
    {
        _paidInstallments.Add(PaidInstallments);
    }

    public void SumTotalExpensesItem() =>
         TotalExpensesItem = Inactive == false ? Amount * CountInstallments : 0;

    public void SumInstallmentsAndTotalRemaning(int payedInstallments)
    {
        PayedInstallments = payedInstallments;
        RemainingInstallments = PayedInstallments > 0 ? CountInstallments - PayedInstallments : 0;

        if (!Inactive)
            TotalExpensesItemRemaining = RemainingInstallments > 0 ? TotalExpensesItem - (Amount * PayedInstallments) : TotalExpensesItem;
    }
}