using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        public string Name => new Random().Next('A', 'Z').ToString();

        private Singleton()
        {
        }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }
}