namespace GeneriskaKlasser2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa repository för produkter
            var produktRepository = new Repository<Produkt>();

            // Skapa och lägg till produkter
            var produkt1 = new Produkt { Id = 1, Namn = "Apple", Pris = 10.5m };
            var produkt2 = new Produkt { Id = 2, Namn = "Banana", Pris = 5.0m };
            produktRepository.Add(produkt1);
            produktRepository.Add(produkt2);

            // Hämta alla produkter
            var produkter = produktRepository.GetAll();
            Console.WriteLine("Produkter:");
            foreach (var produkt in produkter)
            {
                Console.WriteLine($"{produkt.Id}: {produkt.Namn}, Pris: {produkt.Pris}");
            }

            // Uppdatera en produkt
            produkt1.Pris = 12.0m;
            produktRepository.Update(produkt1);

            // Hämta och visa uppdaterad produkt
            var uppdateradProdukt = produktRepository.GetById(1);
            Console.WriteLine($"Uppdaterad produkt: {uppdateradProdukt.Id}: {uppdateradProdukt.Namn}, Pris: {uppdateradProdukt.Pris}");

            // Ta bort en produkt
            produktRepository.Delete(2);

            // Skapa repository för kategorier
            var kategoriRepository = new Repository<Kategori>();

            // Skapa och lägg till kategorier
            var kategori1 = new Kategori { Id = 1, Namn = "Frukt" };
            var kategori2 = new Kategori { Id = 2, Namn = "Grönsaker" };
            kategoriRepository.Add(kategori1);
            kategoriRepository.Add(kategori2);

            // Hämta alla kategorier
            var kategorier = kategoriRepository.GetAll();
            Console.WriteLine("Kategorier:");
            foreach (var kategori in kategorier)
            {
                Console.WriteLine($"{kategori.Id}: {kategori.Namn}");
            }

            // Uppdatera en kategori
            kategori1.Namn = "Tropiska Frukter";
            kategoriRepository.Update(kategori1);

            // Hämta och visa uppdaterad kategori
            var uppdateradKategori = kategoriRepository.GetById(1);
            Console.WriteLine($"Uppdaterad kategori: {uppdateradKategori.Id}: {uppdateradKategori.Namn}");

            // Ta bort en kategori
            kategoriRepository.Delete(2);

            Console.WriteLine("Efter borttagning:");
            kategorier = kategoriRepository.GetAll();
            foreach (var kategori in kategorier)
            {
                Console.WriteLine($"{kategori.Id}: {kategori.Namn}");
            }
        }
    }
}
