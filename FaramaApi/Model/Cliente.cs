namespace FaramaApi.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Cliente(int id,string nome)
        {
            Id = id;
            Name = nome;
        }

    }
}
