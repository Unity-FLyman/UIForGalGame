using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    public string name;
    public GameObject CharaterImage;
    public GameObject NextConversation;
    public GameObject ChooseBranch;
    public GameObject BackGroundImage;
    public int fontSize = 26;
    [TextArea(3,10)]
    public string[] sentens;
    
}
