using System.ComponentModel.DataAnnotations.Schema;

namespace WCE_Api.Entities
{
    public class ShoppingCartItems
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public string ShoppingCartId { get; set; }
    }
}