using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace GolfDistanceAPI.Infrastructure.Factories
{
    public class ServiceFactory : IBaseFactory
    {
        private readonly Dictionary<Type, Type> _registeredTypes;

        public ServiceFactory()
        {
            this._registeredTypes = new Dictionary<Type, Type>();
        }

        public void Register<T, S>() where S : T
        {
            _registeredTypes[typeof(T)] = typeof(S);
        }

        public T Create<T>()
        {
            return (T)Activator.CreateInstance(_registeredTypes[typeof(T)]);
        }
    }
}
