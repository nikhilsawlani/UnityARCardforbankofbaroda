using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picture : MonoBehaviour {
	public GameObject Image;
	// Use this for initialization
	void Start () {
		Image.SetActive (false);
	}

	public void app(){
		Image.SetActive (true);
		Destroy (Image, 7);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
