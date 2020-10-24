using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore.BusinessLayer
{
    public abstract class Card
    {
		private decimal turnover;
		private decimal purchaseValue;

		protected Card(decimal turnover, decimal purchaseValue)
		{
			if (turnover < 0)
				throw new ArgumentOutOfRangeException("Turnover cannot have a negative value!");
			if(purchaseValue <= 0)
				throw new ArgumentOutOfRangeException("Purchase value cannot be less than 0!");
			this.turnover = turnover;
			this.purchaseValue = purchaseValue;
		}

		public decimal PurchaseValue
		{
			get { return purchaseValue; }
			set { purchaseValue = value; }
		}

		public abstract float DiscountRate { get; }

		public decimal Turnover
		{
			get { return turnover; }
			set { turnover = value; }
		}

		protected virtual decimal Total => PurchaseValue - Discount;
		protected virtual decimal Discount => PurchaseValue * (decimal)DiscountRate / 100;
		protected abstract string CardName { get; }
		public override string ToString()
		{
			return $"{CardName} {Environment.NewLine}Purchase value: ${PurchaseValue} {Environment.NewLine}Discount rate: {DiscountRate}% {Environment.NewLine}Discount: ${Discount} {Environment.NewLine}Total: ${Total} {Environment.NewLine} {Environment.NewLine}";
		}

	}
}
