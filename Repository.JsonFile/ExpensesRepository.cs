using System.Text.Json;
using Domain;

namespace Repository.JsonFile;

public class ExpensesRepository : IExpensesRepository
{
    public void Create(ExpensesEntity bank)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<ExpensesEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<ExpensesEntity> GetAllByIdBank(int id) =>
        ReadAll().Where(x => x.IdBank == id).ToList();

    public ExpensesEntity GetById(int id) =>
        ReadAll().SingleOrDefault(x => x.Id == id);

    public IList<ExpensesEntity> ReadAll()
    {
        string jsonExpenses = File.ReadAllText($"C:\\Users\\KleberM2\\Videos\\Captures\\JsonExpenses_{"Json 1"}.json");
        var teste = jsonExpenses.Replace(@"\", "");


        List<ExpensesEntity> expenses = JsonSerializer.Deserialize<List<ExpensesEntity>>(teste);
        return expenses;
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}