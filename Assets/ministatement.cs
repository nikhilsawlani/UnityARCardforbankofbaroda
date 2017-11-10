using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;
//using LitJson.JsonData;

public class ministatement : MonoBehaviour
{
	public Text Tran_Amt;
	public Text Tran_Amt1;
	public Text Tran_Date;
	public Text Tran_Date1;
	public Text Name1;
	public Text Name2;

	private string json;
	private JsonData item;
	// Use this for initialization
	void Start()
	{
		json = File.ReadAllText(Application.dataPath + "/ministatement.json");
		item = JsonMapper.ToObject(json);
		Tran_Amt.text=item["Mini_Statement"][0]["Tran_Amt"].ToString();
		Tran_Date.text=item["Mini_Statement"][0]["Tran_Date"].ToString();
		Tran_Amt1.text=item["Mini_Statement"][1]["Tran_Amt"].ToString();
		Tran_Date1.text=item["Mini_Statement"][1]["Tran_Date"].ToString();
		Name1.text = item ["Mini_Statement"] [0] ["Tran_Rmks"].ToString ();
		Name2.text = item ["Mini_Statement"] [1] ["Tran_Rmks"].ToString ();
	}


	// Update is called once per frame
	void Update()
	{

	}
}