using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Iniciar : MonoBehaviour, IVirtualButtonEventHandler 
{
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.LoadLevel(0);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
