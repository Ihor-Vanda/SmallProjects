using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new(() => new Singleton());


        public static Singleton Instance { get { return instance.Value; } }

        private Singleton() { }
    }
}