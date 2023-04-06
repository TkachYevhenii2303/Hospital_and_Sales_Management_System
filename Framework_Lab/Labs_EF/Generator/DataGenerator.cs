using Bogus;
using Labs_EF.Entities;

namespace Labs_EF.Generator
{
    public static class DataGenerator
    {
        public static List<Visitations> Visitations { get; set; }
        public static List<Patients> Patients { get; set; }
        public static List<Doctors> Doctors { get; set; }
        public static List<Medicaments> Medicaments { get; set; }   
        public static List<Diagnoses> Diagnoses { get; set; }
        public static List<Prescription> Prescriptions { get; set; }

        private const int VISITATIONS = 150;
        private const int DOCTORS = 25;
        private const int PATIENTS = 200;
        private const int DIAGNOSES = 50;
        private const int MEDICAMENTS = 75;
        private const int PRESCRIPTIONS = 100;

        public static void Generate_all_Data()
        {
            Doctors = new Faker<Doctors>()
                .RuleFor(p => p.ID, _ => Guid.NewGuid())
                .RuleFor(d => d.Doctors_name, f => f.Name.FullName())
                .RuleFor(d => d.Specialty, f => f.PickRandom<Specialty>()).Generate(DOCTORS);

            Patients = new Faker<Patients>()
                .RuleFor(p => p.ID, _ => Guid.NewGuid())
                .RuleFor(p => p.Patients_Last, f => f.Name.FirstName())
                .RuleFor(p => p.Patients_First, f => f.Name.LastName())
                .RuleFor(p => p.Email, (f, p) => f.Internet.Email(p.Patients_Last, p.Patients_First))
                .RuleFor(p => p.Address, f => $"The address: {f.Address.FullAddress()}")
                .RuleFor(p => p.Has_Insuranse, f => f.Random.Bool()).Generate(PATIENTS);

            Visitations = new Faker<Visitations>()
                .RuleFor(p => p.ID, _ => Guid.NewGuid())
                .RuleFor(v => v.Date, f => f.Date.Future())
                .RuleFor(v => v.Comments, f => f.Lorem.Sentence())
                .RuleFor(v => v.Patients_ID, f => f.PickRandom(Patients).ID)
                .RuleFor(v => v.Doctors_ID, f => f.PickRandom(Doctors).ID).Generate(VISITATIONS);

            Diagnoses = new Faker<Diagnoses>()
                .RuleFor(d => d.ID, _ => Guid.NewGuid())
                .RuleFor(d => d.Comments, f => f.Lorem.Sentence())
                .RuleFor(d => d.Patiens_ID, f => f.PickRandom(Patients).ID)
                .RuleFor(d => d.Diagnoses_title, f => f.Commerce.Product()).Generate(DIAGNOSES);

            Medicaments = new Faker<Medicaments>()
                .RuleFor(d => d.ID, _ => Guid.NewGuid())
                .RuleFor(d => d.Medicaments_title, f => f.Commerce.Product()).Generate(MEDICAMENTS);

            Prescriptions = new Faker<Prescription>()
                .RuleFor(d => d.ID, _ => Guid.NewGuid())
                .RuleFor(d => d.Medicaments_ID, f => f.PickRandom(Medicaments).ID)
                .RuleFor(d => d.Patients_ID, f => f.PickRandom(Patients).ID).Generate(PRESCRIPTIONS);
        }
    }
}
