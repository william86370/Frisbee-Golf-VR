using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touchgsomethig : MonoBehaviour {

 
    public GameObject text;
    public GameObject fireworks;
    public GameObject wintext;
    public Rigidbody ourfris;
    public Transform ourfrispos;
    public GameObject mainmenu;
    public GameObject wintext2;
    

    
    private int count;

    //Use this for initialization
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "hoop")
        {
            fireworks.SetActive(true);
            wintext.SetActive(true);
            ourfris.isKinematic = true;
            TextMesh textObject = GameObject.Find("frisbeecount").GetComponent<TextMesh>();
            count = System.Convert.ToInt32(textObject.text);
            TextMesh textObject2 = GameObject.Find("wintext2").GetComponent<TextMesh>();
            
            textObject2.text = "Congrats you compleated the hole in " + count + " tries";
            mainmenu.SetActive(true);
            wintext2.SetActive(true);


        }
        if (other.tag == "sechoop")
        {

        }
        if (other.tag == "terr")
        {

           // text.SetActive(true);
            Rigidbody boxistance;
            boxistance = Instantiate(ourfris, ourfrispos.position, ourfrispos.rotation) as Rigidbody;
            TextMesh textObject = GameObject.Find("frisbeecount").GetComponent<TextMesh>();
            count = System.Convert.ToInt32(textObject.text);
            count = count + 1;
            print(count);
            textObject.text = "" + count;
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
    void Update()
    {

    }
}
