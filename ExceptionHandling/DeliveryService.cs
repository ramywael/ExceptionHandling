using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class DeliveryService
    {

        private readonly static Random random = new Random();  
        
        public void Starting(Delivery delivery)
        {
            try
            {
                Processing(delivery);
                Shipping(delivery);
                Transiting(delivery);
                Delivering(delivery);

            }
            catch (LocationException ex)
            {
                Console.WriteLine($"The Parsel IS damged at {ex.Location} Sorry for the {ex.Message}");
                delivery.DeliveryStatus = EnDeliveryStatus.UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                delivery.DeliveryStatus = EnDeliveryStatus.UNKNOWN;
            }
            finally
            {
                Console.WriteLine("End");
            }
        }


        private void Processing(Delivery delivery)
        {
            Fake("Processing");
            if(random.Next(1,10) == 1)
            {
                throw new InvalidOperationException("Unable to process item"); //This is mocking exception
            }
            delivery.DeliveryStatus = EnDeliveryStatus.PROCESSED; 
        }
        private void Shipping(Delivery delivery)
        {
            Fake("Shipping");
            if (random.Next(1, 10) == 1)
            {
                throw new LocationException("345 timesquare NY","Accident !!!!"); //This is mocking exception
            }
            delivery.DeliveryStatus = EnDeliveryStatus.SHIPPED;
        }
        private void Transiting(Delivery delivery)
        {
            Fake("Transiting");
            delivery.DeliveryStatus = EnDeliveryStatus.INTRANSIT;
        }
        private void Delivering(Delivery delivery)
        {
            Fake("Delivering");
            delivery.DeliveryStatus = EnDeliveryStatus.DElIVERED;
        }
        public void Fake(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");
        }
    }
}
