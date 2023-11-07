using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public  List<CR_character> characters;

    // Start is called before the first frame update
    void Start()
    {
        characters = new List<CR_character>();
        CR_character CharData = FileSystem.instance.LoadFromJSON<CR_character>("knight");
        characters.Add(CharData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
