using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string Name;
    public string Description;
    public string[] Data;
    public int id;

    public PlayerData() 
    {
    
    
    }
    public PlayerData(string _name, string _descripcion, int _id)
    {
        Name = _name;
        Description = _descripcion;
        id = _id;
    }
    public PlayerData(PlayerData _data)
    {
      
    
    }
}
