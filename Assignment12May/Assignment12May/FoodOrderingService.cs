using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12May
{
    //Now, to implement an even  we need three things-:

    //1. define a delegate
    //2. define an event that relies on that delegate
    //3. raise an event
    internal class FoodOrderingService
    {
        //defining a deligate 
        public delegate void FoodPrepareEventHandler(object source, EventArgs e);

        //declare an event
        public event FoodPrepareEventHandler FoodPrepared;
        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing order '{order.Item}', please wait.......... ");
            Thread.Sleep(1000);

        }
        //Now after defining and declaring delgate
        // Inorder to raise an event  we should create an actual handler method

        protected virtual void onFoodPrepared(Order order)
        {
            if(FoodPrepared != null)
            {
                FoodPrepared(this, new FoodPreparedEventArgs { Order = Order});
            }
        } 
    }
}
