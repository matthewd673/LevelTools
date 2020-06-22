using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace LevelTools
{
    public static class CavdatHelper
    {

        public static string BakeCavdatFromLevelData(string filepath, Dictionary<string, TilePaint> paintDict, string style)
        {
            //use xml to save the data
            XmlDocument xml = new XmlDocument();
            XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "UTF-8", String.Empty);
            xml.AppendChild(declaration);
            
            //create data section
            XmlElement dataElement = xml.CreateElement("data");
            dataElement.SetAttribute("type", "map");
            xml.AppendChild(dataElement);

            //create style information
            XmlElement paletteElement = xml.CreateElement("palette");
            paletteElement.SetAttribute("style", style.ToLower());
            dataElement.AppendChild(paletteElement);

            //get list of brushes sorted by id
            IEnumerable<TilePaint> paints = paintDict.Values.ToList<TilePaint>().OrderBy(n => n.id);

            //add brushes to palette element
            foreach(TilePaint p in paints)
            {
                XmlElement brushElement = xml.CreateElement("tile");
                brushElement.SetAttribute("id", p.id.ToString());
                brushElement.SetAttribute("type", p.name.ToLower());
                paletteElement.AppendChild(brushElement);
            }

            //create map section
            XmlElement mapElement = xml.CreateElement("map");
            mapElement.SetAttribute("width", LevelData.w.ToString());
            mapElement.SetAttribute("height", LevelData.h.ToString());

            //fill in map text
            string mapText = "";
            for(int i = 0; i < LevelData.w; i++)
            {
                for(int j = 0; j < LevelData.h; j++)
                {
                    mapText += LevelData.map[i, j].ToString() + ",";
                }
            }
            mapText.TrimEnd(','); //trim trailing comma

            mapElement.InnerText = mapText;
            dataElement.AppendChild(mapElement);

            xml.Save(filepath);

            return File.ReadAllText(filepath);

        }

    }
}
