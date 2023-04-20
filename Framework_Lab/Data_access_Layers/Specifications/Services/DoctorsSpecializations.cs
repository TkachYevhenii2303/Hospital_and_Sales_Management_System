using Labs_EF.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_Layers.Specifications.Services
{
    public class DoctorsSpecializations : Specifications<Doctors>
    {
        public DoctorsSpecializations(string specializations) : base(x => x.Specialty == Speciality_string(specializations))
        {
        }

        private static Specialty Speciality_string(string specializations)
        {
            if ( !Enum.TryParse<Specialty>(specializations, true, out var specialty) )
            {
                throw new ArgumentException($"Invalid the specialty result: {specializations}");
            }

            return specialty;
        }
    }
}
