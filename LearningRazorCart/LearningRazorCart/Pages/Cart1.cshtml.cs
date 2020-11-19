using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningRazorCart.Helpers;
using LearningRazorCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningRazorCart.Pages
{
    public class Cart1Model : PageModel
    {
        private readonly online_storeContext _context;

        public List<OrderItem> OrderItems {get ;set;}
        public decimal Total { get; private set; }

        public Cart1Model(online_storeContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            OrderItems = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart1");
            Total = OrderItems.Sum(i => i.Product.ListPrice * i.Quantity);
        }


        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel(_context);
            OrderItems = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart1");
            if (OrderItems == null)
            {
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        Product = productModel.GetDetailById(id),
                        Quantity = 1
                    }
                };

                SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart1", OrderItems);
            }
            else
            {
                int index = Exists(OrderItems, id.ToString());
                if (index == -1)
                {
                    OrderItems.Add(new OrderItem
                    {
                        Product = productModel.GetDetailById(id),
                        Quantity = 1
                    });
                    
                }
                else
                {
                    OrderItems[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart1", OrderItems);
            }
            return RedirectToPage("Cart1");

        }
    }
}
