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
        public DoctorsSpecializations(string specializations) : base(x => x.Specialty.ToString() == specializations)
        {
        }
    }
}
