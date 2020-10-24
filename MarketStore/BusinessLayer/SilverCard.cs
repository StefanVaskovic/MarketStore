using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.BusinessLayer
{
    public class SilverCard : Card
    {
        private static float InitialDisconut => 2f;
        private static float DiscountIfTurnoverIsHigherThan300 => 3.5f;
        public override float DiscountRate
        {
            get
            {
                if (Turnover > 300)
                    return DiscountIfTurnoverIsHigherThan300;
                return InitialDisconut;
            }
        }

        protected override string CardName => "Silver";

        public SilverCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {
        }
        public SilverCard(decimal purchaseValue) : base(0, purchaseValue)
        {
        }

    }
}
