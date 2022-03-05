namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
