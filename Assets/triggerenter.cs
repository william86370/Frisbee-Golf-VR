using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerenter : MonoBehaviour {
    public string hole1;
    public string hole3;
    public string hole6;
    public GameObject text;
	//Use this for initialization
	void Start () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hole1")
        {
            SceneManager.LoadScene(hole1);
        }
        if( other.tag == "hole3")
        {
            SceneManager.LoadScene(hole3);
        }
        if (other.tag == "hole6")
        {
            SceneManager.LoadScene(hole6);

        }
        if(other.tag == "vive")
        {
            SceneManager.LoadScene(hole1);
        }
    }
    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "terr")
        {
            text.SetActive(false);


        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
