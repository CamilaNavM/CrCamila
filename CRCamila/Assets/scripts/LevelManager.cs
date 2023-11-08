using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public  List<CR_character> characters;
    public CR_character CharData;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject card6;
    public GameObject card7;
    public GameObject card8;
    public GameObject card9;
    public GameObject card10;
    public GameObject card11;
    public GameObject card12;
    public GameObject card13;
    public GameObject card14;
    public GameObject card15;
    public GameObject card16;
    public GameObject card17;
    public GameObject card18;
    public GameObject card19;
    public GameObject card20;
    public GameObject card21;
    public GameObject card22;
    public GameObject card23;
    public GameObject card24;
    public GameObject card25;

        
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
        LoadCharacters("Characters"); card1.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[0].name;
        LoadCharacters("Characters"); card2.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[1].name;
        LoadCharacters("Characters"); card3.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[2].name;
        LoadCharacters("Characters"); card4.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[3].name;
        LoadCharacters("Characters"); card5.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[4].name;
        LoadCharacters("Characters"); card6.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[5].name;
        LoadCharacters("Characters"); card7.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[6].name;
        LoadCharacters("Characters"); card8.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[7].name;
        LoadCharacters("Characters"); card9.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[8].name;
        LoadCharacters("Characters"); card10.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[9].name;
        LoadCharacters("Characters"); card11.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[10].name;
        LoadCharacters("Characters"); card12.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[11].name;
        LoadCharacters("Characters"); card13.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[12].name;
        LoadCharacters("Characters"); card14.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[13].name;
        LoadCharacters("Characters"); card15.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[14].name;
        LoadCharacters("Characters"); card16.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[15].name;
        LoadCharacters("Characters"); card17.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[16].name;
        LoadCharacters("Characters"); card18.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[17].name;
        LoadCharacters("Characters"); card19.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[18].name;
        LoadCharacters("Characters"); card20.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[19].name;
        LoadCharacters("Characters"); card21.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[20].name;
        LoadCharacters("Characters"); card22.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[21].name;
        LoadCharacters("Characters"); card23.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[22].name;
        LoadCharacters("Characters"); card24.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[23].name;
        LoadCharacters("Characters"); card25.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[24].name;


        card1.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[0].name;
        //CharData = FileSystem.instance.LoadFromJSON<CR_character>("knight");
        //characters.Add(CharData);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
