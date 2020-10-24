using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.BusinessLayer
{
    public class GoldCard : Card
    {
        private static float InitialDisconut => 2f;
        private static int MaxDiscount => 10;
        public override float DiscountRate
        {
            get
            {
                if (Turnover == 0)
                {
                    return InitialDisconut;
                }
                var discount = Turnover / 100;

                discount = Math.Floor(discount);

                if (discount > MaxDiscount)
                {
                    return MaxDiscount;
                }
                return (float)discount;
            }
        }
        protected override string CardName => "Gold";
        public GoldCard(decimal turnover, decimal purchaseValue) : base(turnover, purchaseValue)
        {
        }
        public GoldCard(decimal purchaseValue) : base(0, purchaseValue)
        {
        }
    }
}
