using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace Lab_Solution
{
    class GameFactory
    {
        List<Game> gameList = new List<Game>();
        public string FilePath { get; set; }

        public void CreateGameList()
        {
            Game g = null;
            g = new Game("Hornets", 50, "Bulldogs", 75);
            gameList.Add(g);
            g = new Game("Wasps", 52, "Panthers", 65);
            gameList.Add(g);
            g = new Game("Bulls", 54, "Bears", 75);
            gameList.Add(g);
            g = new Game("Ducks", 66, "Swans", 65);
            gameList.Add(g);
            g = new Game("Hornets", 82, "Panthers", 75);
            gameList.Add(g);
            g = new Game("Weasels", 80, "Warthogs", 65);
            gameList.Add(g);


        }

        public Boolean SerializeGameList()
        {
            try
            {
                XmlSerializer serial = new XmlSerializer(gameList.GetType());
                StreamWriter sw = new StreamWriter(FilePath);
                serial.Serialize(sw, gameList);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
