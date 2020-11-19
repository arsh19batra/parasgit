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
    public class CartModel : PageModel
    {
        public List<OrderItem> Cart { get; set; }
       // public OrderItem Order_Items { get; set; }
        public decimal Total { get; set; }
        private readonly online_storeContext _context;
        public CartModel(online_storeContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Cart = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart");
            Total = Cart.Sum(i => i.Product.ListPrice * i.Quantity);
        }

        public IActionResult OnGetBuyNow(int id)
        {
            var productModel = new ProductModel(_context);
            Cart = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart");
            if(Cart==null)
            {
                Cart = new List<OrderItem>();
                Cart.Add(new OrderItem
                {
                    Product = productModel.GetDetailById(id),
                    Quantity = 1
                });
                /*_context.OrderItems.Add(new OrderItem
                {
                    Product = productModel.GetDetailById(id),
                    Quantity = 1
                }); 
                _context.SaveChanges();*/
                SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart", Cart);
            }
            else
            {
                int index = Exists(Cart, id.ToString());
                if(index==-1)
                {
                    Cart.Add(new OrderItem{
                        Product = productModel.GetDetailById(id),
                        Quantity = 1
                    });
                    /*_context.OrderItems.Add(new OrderItem
                    {
                        Product = productModel.GetDetailById(id),
                        Quantity = 1
                    });
                    _context.SaveChanges();*/
                }
                else
                {
                    Cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart", Cart);
            }
            return RedirectToPage("Cart");

        }
        public IActionResult OnGetDelete(string id)
        {
            Cart = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart");
            int index = Exists(Cart, id);
            //bool index1 = ProductExists(Int32.Parse(id));
            Cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart", Cart);
            /*if(index1)
            {
                Order_Items=_context.OrderItems.Find(id);
                _context.OrderItems.Remove(Order_Items);
                _context.SaveChanges();
            }*/
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            Cart = SessionHelper.GetObjectFromJson<List<OrderItem>>(HttpContext.Session, "Cart");
            for (var i = 0; i < Cart.Count; i++)
            {
                Cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Cart", Cart);
            //_context.SaveChanges();
            return RedirectToPage("Cart");
        }

        private int Exists(List<OrderItem> Cart, string id)
        {
            for (var i = 0; i < Cart.Count; i++)
            {
                if (Cart[i].Product.ProductId.ToString() == id)
                {
                    return i;
                }
            }
            return -1;
        }
       /* private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }*/

    }
}
