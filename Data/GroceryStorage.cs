using System.Text.Json;
using Grocery_list_api.Models;
namespace Grocery_list_api.Data
{
    public static class GroceryStorage
    {
        private static string filePath = "grocery.json";
        public static List<GroceryItem> Load()
        {
            if (!File.Exists(filePath))
            {
                return new List<GroceryItem>();
            }
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<GroceryItem>>(json) ?? new List<GroceryItem>();
        }
        public static void Save(List<GroceryItem> items)
        {
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
