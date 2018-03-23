using System;
using System.Collections.Generic;
using System.Reflection;
using Factory2.Autos;

namespace Factory2
{
    /// <summary>
    /// A simple auto factory that creates various types of automobiles
    /// based on a key for Type lookup
    /// </summary>
    public class PaymentFactory
    {
        Dictionary<string, Type> payment;

        public PaymentFactory()
        {
            LoadTypesICanReturn();
        }

        public IPayment CreateInstance(string paymentTypes)
        {
            Type t = GetTypeToCreate(paymentTypes);

            if(t == null)
                return new NullPayment();

            return Activator.CreateInstance(t) as IPayment;
        }

        Type GetTypeToCreate(string paymentTypes)
        {
            foreach (var type in payment)
            {
                if (type.Key.Contains(paymentTypes))
                {
                    return payment[type.Key];
                }
            }

            return null;
        }

        void LoadTypesICanReturn()
        {
            payment = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IPayment).ToString()) != null)
                {
                    payment.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}