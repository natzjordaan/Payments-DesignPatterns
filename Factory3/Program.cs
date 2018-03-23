using System.Reflection;
using Factory3.Autos;
using Factory3.Factories;

namespace Factory3
{
    class Program
    {
        static void Main()
        {
            IPaymentFactory paymentFactory = LoadFactory();

            IPayment payment = paymentFactory.StartProcessing();

            payment.Process();
        }

        static IPaymentFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IPaymentFactory;
        }

        //abstract Factory
        //    Provider an interface for creating families of related or dependent objects without specifying their concrete class

        //Unsure which concrete implementation of an interface I want to rerturn
        //Creation should be seperated from representation of an object.
        //    Lot of if/else blocks when deciding which concrete class to create

        //Advantages
        //    Eliminate refrences to concrete classes
        //    -->Factories
        //    -->Object creaated by factories

        //    Factories can be inherited to provider even more specalized
        //    obect creation.

        //    Rules for object initilization is centralized.

        //Disadvantages
        //    May need to create a factory just to get a concrete class
        //    The inheritance hierarcy gets deeper with coupling between concrete factories and created class.
            
    }

}