using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    internal interface IPropertyRepository
    {
        IEnumerable<Property> Properties { get; }
    }
}
