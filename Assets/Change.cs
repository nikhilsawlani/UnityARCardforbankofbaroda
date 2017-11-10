using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {
	public GameObject model1;
	public GameObject model2;
	int i;
	// Use this for initialization
	void Start () {
		model1.SetActive (false);
		model2.SetActive (false);
	}
	
	// Update is called once per frame
	public void change1(){
		int max = 2;
		i = (i + 1) % max;
		if (i == 0) {
			model1.SetActive (true);
			model2.SetActive (false);
		}
		if (i == 1) {
			model2.SetActive (true);
			model1.SetActive (false);
		}
	}



}
