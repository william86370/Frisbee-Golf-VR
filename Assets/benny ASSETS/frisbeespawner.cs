using UnityEngine;

public class frisbeespawner : MonoBehaviour
{
    private SteamVR_TrackedController _controller;
    private PrimitiveType _currentPrimitiveType = PrimitiveType.Sphere;
    public Rigidbody ourfris;
    public Transform ourfrispos;
    public GameObject frisbeecounter;
    
    private int count = 1;

    private void OnEnable()
    {
        _controller = GetComponent<SteamVR_TrackedController>();
        
        _controller.PadClicked += HandlePadClicked;
    }

    private void OnDisable()
    {
        
        _controller.PadClicked -= HandlePadClicked;
    }

  
    

   
    private void HandlePadClicked(object sender, ClickedEventArgs e)
    {
        Rigidbody boxistance;
        boxistance = Instantiate(ourfris, ourfrispos.position, ourfrispos.rotation) as Rigidbody;
        TextMesh textObject = GameObject.Find("frisbeecount").GetComponent<TextMesh>(); 
        count = System.Convert.ToInt32(textObject.text);
        count = count + 1;
       
        textObject.text = ""+ count;
    }
    

}
