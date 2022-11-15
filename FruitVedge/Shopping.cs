namespace FruitVedgeAlgorithm;

public class Shopping
{
    public readonly List<GroceryItem> ShoppingBasket = new List<GroceryItem>();
    
    public List<GroceryItem> GenerateShoppingBasket()
     {

         ShoppingBasket.Add(new GroceryItem { GroceryType = "fruit", Price = 1.21 });
         ShoppingBasket.Add(new GroceryItem { GroceryType = "vedge", Price = 1.40 });
         ShoppingBasket.Add(new GroceryItem { GroceryType = "vedge", Price = 1.69 });

         return ShoppingBasket;
     }

    public void WriteToConsole(List<Shopping> shoppingBasket )
    {
        foreach (Shopping item in shoppingBasket)
        {
            Console.WriteLine(item);
        }
        
    }
    public void WriteToConsole2()
    {
        foreach (GroceryItem item in ShoppingBasket)
        {
            Console.WriteLine(item.GroceryType);
        }
        
    }
    
}