using Nancy;

namespace SimpleNancyExample
{
    public class HeroModule : NancyModule
    {
        private static Hero hero = new Hero()
        {
            Name = "Super Woman"
        };

        public HeroModule()
        {
            Get("/hero", parameters => $"Hello {hero.Name}!");
        }
    }
}
