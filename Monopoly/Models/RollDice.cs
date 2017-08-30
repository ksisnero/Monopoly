using System;

namespace Monopoly.Models
{
    public class RollDice
    {
        public int Roll()
        {
            Random random = new Random();

            int dieValue = random.Next(1, 7);
            return dieValue;
        }
    }
}
