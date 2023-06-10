using Domain;
using Repository.JsonFile;

namespace Application; 

public class ExpensesService : IExpensesService
{
    private readonly IExpensesRepository _expensesRepository; 

    public ExpensesService ()
    {
        _expensesRepository = new ExpensesRepository();
    }
    public List<ExpenseDto> GetExpenseByIdBank(int idBank)
    {
        List<ExpenseDto> lstExpenses = new List<ExpenseDto>();
        _expensesRepository.GetAllByIdBank(idBank).ForEach(x => lstExpenses.Add(MappingEntityToDto(x)));
        
        return lstExpenses; 
    }

    public ExpensesEntity MappingDtoToEntity(ExpenseDto obj)
    {
        throw new NotImplementedException();
    }

    public ExpenseDto MappingEntityToDto(ExpensesEntity obj)
    {
        throw new NotImplementedException();
    }
}