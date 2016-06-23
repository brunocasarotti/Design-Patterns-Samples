using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroToCreate = args[0];
            var factory = new HeroFactory();

            var hero = factory.CreateInstance(heroToCreate);
        }
    }
}
