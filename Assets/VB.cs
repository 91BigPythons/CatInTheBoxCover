using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb;

    // Start is called before the first frame update
    void Start()
    {
        // Correct the method names to match the actual method definitions
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
    }

    // Correct the method name to match the registered name in Start()
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    // Correct the method name to match the registered name in Start()
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }
}
