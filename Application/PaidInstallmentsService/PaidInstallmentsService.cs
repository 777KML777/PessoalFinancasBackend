using Domain;

namespace Application;

public class PaidInstallmentsService : IPaidInstallmentsService
{

    private readonly IPaidInstallmentsRepository _paidInstallmentsRepository;
    public List<PaidInstallmentsDto> GetAllPaidByIdExpenses(int idExpenses)
    {
        List<PaidInstallmentsDto> lstPaidInstallmentss = new List<PaidInstallmentsDto>();
        _paidInstallmentsRepository.GetAllPaidByIdExpenses(idExpenses).ToList().ForEach(x => lstPaidInstallmentss.Add(MappingEntityToDto(x)));

        return lstPaidInstallmentss;
    }
    public PaidInstallmentsEntity MappingDtoToEntity(PaidInstallmentsDto obj)
    {
        throw new NotImplementedException();
    }

    public PaidInstallmentsDto MappingEntityToDto(PaidInstallmentsEntity obj)
    {
        throw new NotImplementedException();
    }
}