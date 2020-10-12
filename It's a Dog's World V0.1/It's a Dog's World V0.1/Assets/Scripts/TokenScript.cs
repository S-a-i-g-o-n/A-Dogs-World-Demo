using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
	public UiManager ui;
	// Start is called before the first frame update
    void Start()
    {
    	ui = GameObject.FindWithTag ("ui").GetComponent<UiManager> ();
        
    }

    void OnCollisionEnter2D(Collision2D col){
    	if (col.gameObject.tag == "Token") {
			ui.IncrementScore ();
    		Destroy (gameObject);}
    	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
