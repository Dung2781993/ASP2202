using Hospital.DAL;
using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.Seeding
{
    public class PrescriptionGenerator
    {
        public static void InitialPrescriptionSeed(HospitalContext context)
        {
            Random random = new Random();

            var allMedicamentIds = context.Medicaments.Select(item => item.MedicamentId).ToArray();
            var allPatients = context.Patients.Select(item => item.PatientId).ToArray();

            foreach(var item in allMedicamentIds)
            {
                var patientCount = random.Next(1,4);
                var medicamentIds = new int[patientCount];

                for(int i = 0; i < patientCount; i++)
                {
                    var index = -1;
                    while(!allMedicamentIds.Contains(index) || medicamentIds.Contains(index))
                    {
                        index = random.Next(allMedicamentIds.Max());
                    }
                    medicamentIds[i]++;
                }

                var prescriptions = new List<PatientMedicament>();
                foreach(var i in medicamentIds)
                {
                    var prescription = new PatientMedicament()
                    {
                        PatientId = item,
                        MedicamentId = i
                    };

                    prescriptions.Add(prescription);
                }
                context.Patients.Find(item).Prescriptions = prescriptions;
            }

            context.SaveChanges();
        }

        public static void NewPrescription(int patientId, int medicamentId, HospitalContext context)
        {
            var prescription = new PatientMedicament()
            {
                PatientId = patientId,
                MedicamentId = medicamentId,
            };

            context.Patients.Find(patientId).Prescriptions.Add(prescription);
            context.SaveChanges();
        }
    }
}