using System;
using System.Runtime.CompilerServices;

namespace Singleton
{
    public class Singleton
    {
        private static volatile Singleton _instance;
        public string Name => new Random().Next('A', 'Z').ToString();

        private Singleton()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}