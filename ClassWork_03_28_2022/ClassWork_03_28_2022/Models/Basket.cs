using System;
using System.Collections.Generic;
using System.Text;
using ClassWork_03_28_2022.Exceptions;
namespace ClassWork_03_28_2022.Models
{
    class Basket
    {

        public int productLimit { get; set; }
        public List<Product> products { get; set; }

        public void AddProduct(Product prod)
        {
            if (prod.Count < productLimit)
            {
                prod.Count++;
                prod.StockCount--;
                products.Add(prod);
            }
            throw new CapacityLimitException("");
        }

        public void RemoveProduct(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (var item in products)
                {
                    if (item.Id == id)
                    {
                        products.Remove(item);
                        return;
                    }
                    throw new ProductNotFoundException("Product not found!!!");
                }
            }

        }

        public void RemoveAllProducts()
        {
            products.Clear();
        }

        public void IncreaseProductCount(Product prod)
        {
            if (prod.StockCount > 0)
            {
                prod.Count++;
                prod.StockCount--;
            }
            
        }

        public void DecreaseProductCount(Product prod)
        {
            if (prod.Count ==1)
            {
                prod.Count--;
                prod.StockCount++;

                products.Remove(prod);
            }
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }


    }
}
