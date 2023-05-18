using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    internal class EventHandling
    {
        public event EventHandler<bool> FoodDelivered;
        public void FoodDeliveryDone()
        {
            try
            {
                Console.WriteLine("Delivery process started");
                OnBilling(true);
            }
            catch 
            {
                OnBilling(false);
            }
        }

        public void OrderRecived()
        {
            Console.WriteLine("Order Recieved");
            PreparingFood(EventArgs.Empty);

        }

        public void PreparingFood(EventArgs e) 
        {
            Console.WriteLine("Food is Preparing");
            OnBilling(true);
        }

        public void OnBilling(bool IsSuccessful)
        {
            Console.WriteLine("Bill Done");
            FoodDelivered?.Invoke(this, IsSuccessful);
        }
    }
}
