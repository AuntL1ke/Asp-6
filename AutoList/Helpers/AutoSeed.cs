using AutoList.Models;

namespace AutoList.Helpers
{
    public static class AutoSeed
    {
        public static List<Auto> Autos { get; set; }

        public static List<Auto> Seed()
        {
            return new List<Auto>()
            {
                new Auto()
                {
                    Id = 1,
                    Model = "Ford Mondeo",
                    Color = "Black",
                    BodyType = "Sedan",
                    Year = 2008
                },
                new Auto()
                {
                    Id = 2,
                    Model = "KIA Sportage",
                    Color = "White",
                    BodyType = "Sedan",
                    Year = 2009
                },
            };
        }
    }
}
