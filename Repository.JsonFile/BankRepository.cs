using System.Text.Json;
using Domain;


namespace Repository.JsonFile
{
    public class BankRepository : IBankRepository
    {
        public void Update()
        {
            //Deserializar para um objeto a lista toda 
            // Atualizar somente o que eu tenho o Id no momento 
            // Salvar toda a coleção e não apenas um item. Modificando da lista apenas o item que tem que ser modificado. 
            
            // Criando o nome do arquivo com DateTime no final eu teria um "Histórico de Movimentações" a cada de input ou deleção feita no banco...
            // Ser preciso na responsabilidade de cada método. 
            // Ser preciso para não ficar muito código escrito em muitas colunas
            // Levantar requisitos até mesmo na funcionalidade, pensar demais facilita o desenvolver do problema e do mini problema. 
        }


        public void Create(BankEntity bank)
        {
            List<BankEntity> banksJson = ReadAll().ToList();
            banksJson.Add(bank);

            File.WriteAllText($"C:\\Users\\KleberM2\\Videos\\Captures\\JsonBank_{"Json 1"}.json", JsonSerializer.Serialize(banksJson));
        }

        public IList<BankEntity> ReadAll()
        {

            string jsonBanks = File.ReadAllText($"C:\\Users\\KleberM2\\Videos\\Captures\\JsonBank_{"Json 1"}.json");
            var teste = jsonBanks.Replace(@"\", "");


            List<BankEntity> banks = JsonSerializer.Deserialize<List<BankEntity>>(teste);
            return banks;
        }

        public void Update(int id)
        {
            // Mesma coisa do Create. Porém irei atualizar e sobreescrever o arquivo
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // Mesma coisa do Create e Update. Porém irei deletar e sobreescrever o arquivo
            throw new NotImplementedException();
        }

        public BankEntity GetById(int id) =>
            ReadAll().SingleOrDefault(x => x.Id == id);

    }
}
