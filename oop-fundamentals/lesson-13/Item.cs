namespace Lesso13
{
    class Item
    {
        public Item(int itemId, string itemName, double itemPrice, int purchaseId)
        {
            if (purchaseId <= 0)
            {
                throw new ArgumentException("Purchase id must be positive");
            }
            if (itemId <= 0)
            {
                throw new ArgumentException("Item id must be positive");
            }

            this.ItemId = itemId;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.PurchaseId = purchaseId;
        }

        public int ItemId { get; private set; }

        private string itemName;
        public string ItemName
        {
            get => this.itemName;
            private set
            {
                this.itemName = (value.Length > 100) ?
                    throw new ArgumentException("Item name must be less than 100 characters") : value;
            }
        }

        private double itemPrice;
        public double ItemPrice
        {
            get => this.itemPrice;
            private set
            {
                this.itemPrice = (value < 0) ?
                    throw new ArgumentException("Item price must be positive") : value;
            }
        }
        public int PurchaseId { get; private set; }

    }
}