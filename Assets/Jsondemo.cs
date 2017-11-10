using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Jsondemo : MonoBehaviour {
    public Text bank; 
    string path;
    string Jsonstring;

	// Use this for initialization
	void Start () {
        path = Application.streamingAssetsPath + "/json1.json";
        Jsonstring = File.ReadAllText(path);
        json1 hello = JsonUtility.FromJson<json1>(Jsonstring);
        bank.text=hello.Available_Balance.ToString();
	}
	
	// Update is called once per frame
	
}

[System.Serializable]
public class json1
{
    public int Account_Number;
    public string Type_of_account;
    public float Available_Balance;
    public string Customer_Name;
}
