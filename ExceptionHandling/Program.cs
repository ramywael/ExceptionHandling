namespace ExceptionHandling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* -------------------------------1----------------------------
            //try
            //{
            //    BadMethod(); //We put the method or the code where we ecpect to make an exception
            //}
            //catch
            //{
            //    //Here We Handle the Exception
            //    Console.WriteLine("You CANNOT divide over ZERO");
            //}
            //finally
            //{
            //    //Whether the excaption happeans or not this part will be Executed
            //    Console.WriteLine("End");
            //}
            */


            /*  ------------------------------2---------------------------
            try
            {
                BadMethod(); //We put the method or the code where we ecpect to make an exception
            }
            catch(DivideByZeroException ex) // The More we become specific
            {
                //Here We Handle the Exception
                Console.WriteLine("You CANNOT divide over ZERO");
            }
            finally
            {
                //Whether the excaption happeans or not this part will be Executed
                Console.WriteLine("End");
            }
            */

            /* ------------------------------3---------------------------
            try
            {
                BadMethod(); //We put the method or the code where we ecpect to make an exception
            }
            catch(ArgumentNullException ex)
            {
                //Here We Handle the Exception
                Console.WriteLine("You CANNOT divide over ZERO");
            }
            catch (DivideByZeroException ex)
            {
                //Here We Handle the Exception
                Console.WriteLine("You CANNOT divide over ZERO");
            }
            catch (Exception ex) //Specific to Generalization 
            {
                //Here We Handle the Exception
                Console.WriteLine("You CANNOT divide over ZERO");
            }
            finally
            {
                //Whether the excaption happeans or not this part will be Executed
                Console.WriteLine("End");
            }
            */

            /* -------------------------------4---------------------------
             try
             {
                 BadMethod(); //We put the method or the code where we ecpect to make an exception
             }
             catch(DivideByZeroException ex) when (ex.Source == "ExceptionHandling2") //Filtering the exception
             {
                 //Here We Handle the Exception
                 Console.WriteLine("You CANNOT divide over ZERO");
             }
             finally
             {
                 //Whether the excaption happeans or not this part will be Executed
                 Console.WriteLine("End");
             }
            */

            Delivery delivery = new Delivery() { 
                Id ="1",
                Adress ="Giza",
                CustomerName ="Ramy",
            };
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.Starting(delivery);
            Console.WriteLine(delivery);

        }

        static int BadMethod()
        {
            int x = 2;
            int y = 0;
            return x / y;
        }
    }
}
