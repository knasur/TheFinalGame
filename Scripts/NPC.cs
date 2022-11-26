using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    [SerializeField] AudioSource Hello;
    public GameObject Canvas;
    public GameObject Dialouge;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Canvas.SetActive(false);
            Dialouge.SetActive(true);
            Hello.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Dialouge.SetActive(false);
            Canvas.SetActive(true);
        }
     }
    void OnTriggerEnter(Collider other)
    {
        Canvas.SetActive(true);

        
    }
    void OnTriggerExit(Collider other)
    {
        Canvas.SetActive(false);
        
    }
}
