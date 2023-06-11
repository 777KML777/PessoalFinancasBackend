using System.Text.Json;
using Domain;

namespace Repository.JsonFile;

public class PaidInstallmentsRepository : IPaidInstallmentsRepository
{
    public void Create(PaidInstallmentsEntity bank)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IList<PaidInstallmentsEntity> GetAllPaidByIdExpenses(int idExpenses) => 
        ReadAll().Where(x => x.IdExpenses == idExpenses).ToList();

    public PaidInstallmentsEntity GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<PaidInstallmentsEntity> ReadAll()
    {
        string paidInstallmentsJson = File.ReadAllText($"C:\\Users\\KleberM2\\Videos\\Captures\\JsonPaidInstallments.json");
        var teste = paidInstallmentsJson.Replace(@"\", "");


        List<PaidInstallmentsEntity> paidInstallments = JsonSerializer.Deserialize<List<PaidInstallmentsEntity>>(teste);
        return paidInstallments;
    }

    public void Update(int id)
    {
        throw new NotImplementedException();
    }
}