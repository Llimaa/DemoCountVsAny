namespace DemoCountVsAny;

public class Client(int id, string name)
{
    public static IEnumerable<Client> GetClient()
    {
        var clients = new List<Client>();
        for (int i = 1; i <= 500; i++)
        {
            clients.Add(new Client(i, $"Marcos"+i));
        };
        
        return clients;
    }

    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
}
