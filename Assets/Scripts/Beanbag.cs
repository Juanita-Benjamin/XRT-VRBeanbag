using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Beanbag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Thrown()
    {
        BagController.Instance.SpawnBag();
        //GetComponent<XRGrabInteractable>().enabled = false;
        gameObject.layer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
