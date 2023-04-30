using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project_For_Monthly_03.Factories
{
    public class ModelFactory : IModelFactory
    {
        public T Create<T>(params object[] args) where T : class
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }

    }
}
