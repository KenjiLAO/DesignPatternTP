using System.Text.Json;

public class JsonFormat
{
    public void SauvegarderEnJson<T>(T objet, string chemin)
    {
        string json = JsonSerializer.Serialize(objet, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(chemin, json);
    }

    public T ChargerDepuisJson<T>(string chemin)
    {
        if (File.Exists(chemin))
        {
            string json = File.ReadAllText(chemin);
            return JsonSerializer.Deserialize<T>(json);
        }
        return default(T);
    }
}