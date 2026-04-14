using System.Xml.Linq;

namespace GameFramework.Utils
{
    public class ConfigLoader
    {
        public static GameConfig Load(string path)
        {
            var doc = XDocument.Load(path);

            var world = doc.Root.Element("World");

            return new GameConfig
            {
                MaxX = int.Parse(world.Element("MaxX").Value),
                MaxY = int.Parse(world.Element("MaxY").Value),
                Difficulty = doc.Root.Element("Difficulty").Value
            };
        }
    }
}