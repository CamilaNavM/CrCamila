using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class LevelManager : MonoBehaviour
{
    public  List<CR_character> characters;
    public CR_character CharData;

    public void LoadCharacters(string _fileName)
    {
        string path = Application.dataPath + "/resources/" + _fileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(data);

        
        for (int i = 0; i< resource.Count; i++)
        {
            CR_character character = new CR_character();
            character.name = resource[i]["name"].Value;
            character.rarity = resource[i]["rarity"].Value;
            character.id = int.Parse(resource[i]["id"].Value);
            characters.Add(character);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
        characters = new List<CR_character>();
        LoadCharacters("characters");
        //CharData = FileSystem.instance.LoadFromJSON<CR_character>("knight");
        characters.Add(CharData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
