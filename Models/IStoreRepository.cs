using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public interface IStoreRepository
    {
        public IEnumerable<Product> products { get; }
    }
}
