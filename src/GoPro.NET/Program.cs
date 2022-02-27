using GoPro.NET.Models;
using GoPro.NET.Repositories.GoPro.Hero;
using GoPro.NET.Repositories.GoPro.Hero10;
using Microsoft.Extensions.DependencyInjection;

namespace GoPro.NET
{
    public class Program
    {
        public void Run()
        {
            Console.WriteLine("Test");
        }
        static void Main(string[] args)
        {
            var host = Bootstrap.CreateHostBuilder(args).Build();
            IHero hero = host.Services.GetRequiredService<Hero10>();

            Task.Run(() =>
            {
                var autoOff = hero.SetAutoOff(HeroAutoOff.AutoOff15);

            }).Wait();

            Console.ReadLine();
        }
    }
}