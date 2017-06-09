using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMng : MonoBehaviour {

    GameObject splash;

	// Use this for initialization
	void Start () {
        AndroidNFCReader.enableBackgroundScan();
        AndroidNFCReader.ScanNFC(gameObject.name, "OnFinishScan");
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            GameObject splash = (GameObject)Resources.Load("Prefabs/Splash");
            Instantiate(splash, new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Quaternion.identity);
        }

    }

    //Nfc callback
    void OnFinishScan(string result) {
        if (result == AndroidNFCReader.CANCELLED)
        {
            // The user has canceled the scan (back button)
        }
        else if (result == AndroidNFCReader.ERROR)
        {
            // There was an error reading the NFC tag
        }
        else if (result == AndroidNFCReader.NO_HARDWARE)
        {
            // No NFC hardware available
        }

        Debug.Log("AndroidNFCReader called");
    }
}

