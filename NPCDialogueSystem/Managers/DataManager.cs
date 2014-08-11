using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace NPCDialogueSystem
{
    static class DataManager
    {
        static public string RootDirectory { get { return @"Resources\"; } }
        static public string Path { get { return RootDirectory + "NPCs.xml"; } }

        static private Dialogue searchById(int id)
        {
            var formattedId = id.ToString();
            XmlReaderSettings xmlSettings = new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document };

            using (var reader = XmlReader.Create(Path, xmlSettings))
            {
                // Reads the xml.
                while (reader.Read())
                {
                    // Verifies whether the current line matches the sought element.
                    if ((reader.IsStartElement()) && (formattedId == reader["id"]))
                    {
                        return readDialogue(reader);
                    }
                }
            }

            return null;
        }

        static private Dialogue readDialogue(XmlReader reader)
        {
            var dialogue = new Dialogue();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "name":
                            dialogue.Name = reader["text"];
                            break;

                        case "greeting":
                            dialogue.Greeting = reader["text"];
                            break;

                        case "options":
                            var dialogueOptions = new Dictionary<string, DialogueOption>();
                            var subsequentIdList = new List<string[]>();

                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element)
                                {
                                    var dialogueOption = new DialogueOption()
                                    {
                                        Category = (Category)int.Parse(reader["category"]),
                                        Visible = (reader["visible"] == null) ? true : bool.Parse(reader["visible"]),
                                        Text = reader["text"],
                                        Reply = reader["reply"]
                                    };

                                    if (reader["leadsTo"] != null)
                                    {
                                        subsequentIdList.Add(reader["leadsTo"].Split(';'));
                                    }
                                    else subsequentIdList.Add(new string[] { });
                                    dialogueOptions.Add(reader["id"], dialogueOption);
                                }
                            }

                            var index = 0;
                            dialogue.DialogueOptions = new List<DialogueOption>();
                            
                            foreach (var option in dialogueOptions)
                            {
                                foreach (var id in subsequentIdList[index])
                                {
                                    var subsequentOption = dialogueOptions[id];
                                    option.Value.SubsequentOptions.Add(subsequentOption);
                                }

                                dialogue.DialogueOptions.Add(option.Value);
                                ++index;
                            }

                            dialogue.Initialize();
                            
                            break;
                    }
                }
            }

            return dialogue;
        }

        static public T Load<T>(int id) where T : Dialogue
        {
            if (typeof(T) == typeof(Dialogue))
            {
                var result = searchById(id);
                return result as T;
            }
            else return null;
        }
    }
}
