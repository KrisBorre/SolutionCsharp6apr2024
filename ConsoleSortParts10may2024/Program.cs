namespace ConsoleSortParts10may2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Part> parts = new List<Part>();
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "special seat", PartId = 1435 });
            parts.Add(new Part() { PartName = "headrest", PartId = 213 });
            parts.Add(new Part() { PartName = "backrest", PartId = 214 });
            parts.Add(new Part() { PartName = "lumbar support", PartId = 215 });
            parts.Add(new Part() { PartName = "seat cushion", PartId = 216 });
            parts.Add(new Part() { PartName = "bolster side support", PartId = 5322 });
            parts.Add(new Part() { PartName = "armrest", PartId = 5323 });
            parts.Add(new Part() { PartName = "seatbelt buckle", PartId = 5324 });
            parts.Add(new Part() { PartName = "seatbelt receiver", PartId = 5325 });

            // Sort the list by PartId (ascending)
            parts.Sort();

            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }

            /*
            ID: 213   Name: headrest
            ID: 214   Name: backrest
            ID: 215   Name: lumbar support
            ID: 216   Name: seat cushion
            ID: 1434   Name: regular seat
            ID: 1435   Name: special seat
            ID: 5322   Name: bolster side support
            ID: 5323   Name: armrest
            ID: 5324   Name: seatbelt buckle
            ID: 5325   Name: seatbelt receiver
            */

            Console.Read();
        }
    }

    public class Part : IComparable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        public override string ToString()
        {
            return $"ID: {PartId}   Name: {PartName}";
        }

        public int CompareTo(Part comparePart)
        {
            if (comparePart == null) return 1;
            else return this.PartId.CompareTo(comparePart.PartId);
        }
    }
}
