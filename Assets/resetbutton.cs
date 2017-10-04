using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class resetbutton : MonoBehaviour {


    public string newscene;
    //Use this for initialization
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "vive")
        {
            SceneManager.LoadScene(newscene);
        }
        if (other.tag == "terr")
        {
            

        }
    }
    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "terr")
        {
          ;


        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
