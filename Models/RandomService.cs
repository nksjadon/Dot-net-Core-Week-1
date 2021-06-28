using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tata_Power_App.Models
{
    public class RandomService : IRandomService
    {
        private int _randomNumber;

        public RandomService()
        {
            Random random = new Random();
            _randomNumber = random.Next(10000);
        }
        public int getNumber()
        {
            return _randomNumber;
        }
    }
}
