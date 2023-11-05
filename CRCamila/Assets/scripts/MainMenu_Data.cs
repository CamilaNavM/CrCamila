using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public struct CRData
{
    public int Level;
  public int Gold;
  public int Emeralds;
  public string User;
  public string Clan;

}
public class MainMenu_Data : MonoBehaviour
{

    [Header("MAIN MENU CONFIG")]
    public CRData data;
    [Header("MAIN MENU UI")]

    public TMP_Text Level;
    public TMP_Text Gold;
    public TMP_Text Emeralds;
    public TMP_Text User;
    public TMP_Text Clan;

    // Start is called before the first frame update
    void Start()
    {
         Level.text = data.Level.ToString() + " / 100";
        Gold.text = data.Gold.ToString();
        Emeralds.text = data.Emeralds.ToString();
        User.text = data.User;
        Clan.text = data.Clan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
