namespace ObjectOrientedPrograms
{
    public class ItemDetails
    {
        public String name;
        public int weight;
        public int price_per_kg;
        public int totalPrice;

        public ItemDetails(string name, int weight, int price_per_kg, int totalPrice)
        {
            this.name = name;
            this.weight = weight;
            this.price_per_kg = price_per_kg;
            this.totalPrice = totalPrice;
        }
    }
}