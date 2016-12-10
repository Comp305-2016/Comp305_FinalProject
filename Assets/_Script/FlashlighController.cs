using UnityEngine;
using System.Collections;

public class FlashlighController : MonoBehaviour {

    public Light flashlight;
    
   
    private bool _isActive;
    // Use this for initialization
    void Start () {
        
        this._isActive = true;
        flashlight.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
       
            Debug.Log("key can be pressed");
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                switch (this._isActive)
                {
                    case true:
                        flashlight.enabled = false;
                        this._isActive = false;
                        break;
                    case false:
                        flashlight.enabled = true;
                        this._isActive = true;
                        break;
                    default:
                        break;

                }
                Debug.Log("active? : " + this._isActive);

           }
            
        
	}
    
}
