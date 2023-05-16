using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.clsEnums
{
    public class Enums
    {
        public enum Gender
        {
            Male = 0,
            Female = 1,
            Other = 2,
        }
        public enum UserRole
        {
            Administrator = 0,
            Registrar = 1,
            Student = 2,
        }
    }
}
