using Hospital.DAL;
using Hospital.Models;

namespace Hospital.Seeding
{
    public class MedicamentGenerator
    {
        public static void InitialMedicamentSeed(HospitalContext context)
        {
            var medicamentNames = new string[]
            {
                "Medicament1",
                "Medicament2",
                "Medicament3",
                "Medicament4",
                "Medicament5"
            };

            for(var i = 0; i < medicamentNames.Length; i++)
            {
                context.Medicaments.Add(new Medicament()
                {
                    Name = medicamentNames[i]
                });
            }
        }

        public static void Generate(string name, HospitalContext context)
        {
            context.Medicaments.Add(new Medicament()
            {
                Name = name
            });
        }
    }
}