using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ObjectOrientedPrograms
{
    internal class JSONInventory
    {
        public void PriceCalculation()
        {
            int costRice = 0, costPulses = 0, costWheats = 0;
            string jsonPath = "D:\\BridgeLabz\\BridgeLabz_Refresher\\ObjectOrientedPrograms\\inventory.json";
            string inventoryData = File.ReadAllText(jsonPath);
            var items = JsonConvert.DeserializeObject<InventoryItem>(inventoryData);
            InventoryItem inventoryItem = new InventoryItem();

            int k = 0;
            ItemDetails[] details = new ItemDetails[items.Rice.Length];
            foreach (var item in items.Rice)
            {
                costRice = item.price_per_kg * item.weight;
                details[k++] = new ItemDetails(item.name, item.weight, item.price_per_kg, costRice);
                inventoryItem.Rice = details;
            }

            k = 0;
            details = new ItemDetails[items.Pulses.Length];
            foreach (var item in items.Pulses)
            {
                costPulses = item.price_per_kg * item.weight;
                details[k++] = new ItemDetails(item.name, item.weight, item.price_per_kg, costPulses);
                inventoryItem.Pulses = details;
            }

            k = 0;
            details = new ItemDetails[items.Wheats.Length];
            foreach (var item in items.Wheats)
            {
                costWheats = item.price_per_kg * item.weight;
                details[k++] = new ItemDetails(item.name, item.weight, item.price_per_kg, costWheats);
                inventoryItem.Wheats = details;
            }

            string ResultJson = JsonConvert.SerializeObject(inventoryItem);
            Console.WriteLine("\nCalculating the total price and writing the details to the file...");
            string Path = "D:\\BridgeLabz\\BridgeLabz_Refresher\\ObjectOrientedPrograms\\newInventory.json";
            File.WriteAllText(Path, ResultJson);

        }
    }
}
