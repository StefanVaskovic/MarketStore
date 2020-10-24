using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.BusinessLayer
{
    public class BronzeCard : Card
    {
        private static float DiscountIfTurnoverIsLessThan100 => 0;
        private static float DiscountIfTurnoverIsBetween100And300 => 1;
        private static float DiscountIfTurnoverIsHigherThan300 => 2.5f;
        public override float DiscountRate
        {
            get
            {
                if (Turnover < 100)
                    return DiscountIfTurnoverIsLessThan100;
                if (Turnover >= 100 && Turnover <= 300)
                    return DiscountIfTurnoverIsBetween100And300;
                return DiscountIfTurnoverIsHigherThan300;
            }
        }
        protected override string CardName => "Bronze";
        public BronzeCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {

        }
        public BronzeCard(decimal purchaseValue) : base(0, purchaseValue)
        {

        }
    }
}
