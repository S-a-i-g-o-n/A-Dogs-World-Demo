using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	public GameObject Youwin;
    
    private void OnTriggerEnter(Collider other)
    {
    	if(other.gameObject.tag == "Player")
    	{

    		Youwin.gameObject.SetActive(true);
    	}
    }
}
