using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        Canvas.SetActive(true);
        Box.SetActive(false);
    }
    void OnTriggerExit(Collider other)
    {
        Canvas.SetActive(false);
        Box.SetActive(true);
    }
}
