using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fossil : MonoBehaviour {
    private bool isBuried;
    private bool isChecked;
    GameObject playManagerObj;
    private PlayManager manager;
    // Use this for initialization
    void Start () {
        playManagerObj = GameObject.Find("PlayManagerObj");
        manager = playManagerObj.GetComponent<PlayManager>();
	}
	
	// Update is called once per frame
	void Update () {
    
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
           manager.AddRockName(other.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Rock")
        {
            manager.RemoveRockName(other.name);
        }
    }
}
