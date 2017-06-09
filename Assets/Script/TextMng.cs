using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMng : MonoBehaviour {
	Text myText;


	// Use this for initialization
	void Start () {
		myText = GetComponent<Text> ();
		myText.text = "Game Start";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
