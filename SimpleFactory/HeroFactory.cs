using SimpleFactory.Heroes;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SimpleFactory
{
    class HeroFactory
    {
        Dictionary<string, Type> heroes;
        public HeroFactory()
        {
            heroes = LoadHeroes();
        }

        public IHero CreateInstance(string heroToCreate)
        {
            var type = TypeToCreate(heroToCreate);

            if (type != null)
                return Activator.CreateInstance(type) as IHero;
            else
                return null; //TODO: Implement null pattern here ;)
        }

        private Type TypeToCreate(string heroToCreate)
        {
            if (heroes.ContainsKey(heroToCreate))
                return heroes[heroToCreate];
            else
                return null;
        }

        private Dictionary<string, Type> LoadHeroes()
        {
            heroes = new Dictionary<string, Type>();

            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var item in types)
            {
                if (item.GetInterface(typeof(IHero).ToString()) != null)
                    heroes.Add(item.Name.ToLower(), item);
            }

            return heroes;
        }
    }
}
