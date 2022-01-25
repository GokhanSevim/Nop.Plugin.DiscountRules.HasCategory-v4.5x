using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Orders;
using System.Collections.Generic;

namespace Nop.Plugin.DiscountRules.HasCategory.Models
{
    public record CartModel
    {
        public ShoppingCartItem CartItem { get; set; }

        public IList<ProductCategory> Category { get; set; }
    }
}
