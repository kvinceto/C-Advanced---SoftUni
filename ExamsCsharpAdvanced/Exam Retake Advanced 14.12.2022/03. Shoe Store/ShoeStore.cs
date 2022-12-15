using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; private set; }
        public int StorageCapacity { get; private set; }
        public List<Shoe> Shoes { get; private set; }

        public int Count => this.Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (this.StorageCapacity == this.Count)
            {
                return "No more space in the storage room.";
            }

            this.Shoes.Add(shoe);
            return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            List<Shoe> toBeRemoved = this.Shoes.Where(s => s.Material == material).ToList();
            foreach (var shoe in toBeRemoved)
            {
                this.Shoes.Remove(shoe);
            }
            return toBeRemoved.Count;
        }

        public List<Shoe> GetShoesByType(string type)
            => this.Shoes.Where(s => s.Type.ToLower() == type.ToLower()).ToList();


        public Shoe GetShoeBySize(double size) 
            => this.Shoes.FirstOrDefault(s => s.Size == size);

        public string StockList(double size, string type)
        {
            List<Shoe> shoeList = this.Shoes.Where(s => s.Size == size && s.Type == type).ToList();
            if (shoeList.Count == 0)
                return "No matches found!";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            foreach (var shoe in shoeList)
            {
                sb.AppendLine(shoe.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
