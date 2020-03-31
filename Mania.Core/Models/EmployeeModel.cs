using System;
using System.Collections.Generic;
using System.Text;

namespace Mania.Core.Models
{
    class EmployeeModel : UserModel
    {
        public EstablishmentModel Establishment { get; set; }
    }
}
