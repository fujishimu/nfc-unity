using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour {
    private ParticleSystem particle;

	// Use this for initialization
	void Start () {
        particle = this.GetComponent<ParticleSystem>();
        particle.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = position;
            particle.Play();
        }   
		
	}
}
