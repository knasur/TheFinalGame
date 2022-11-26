using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyPads : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator DoorOp;
    [SerializeField] AudioSource DoorSlide;
    [SerializeField] AudioSource Wrong;
    [SerializeField] AudioSource Correct;


    private string Answer = "309";
    public GameObject KeyPad;
    public GameObject Close;

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "Correct";
            DoorOp.SetBool("Open",true);
            DoorSlide.Play();
            Correct.Play();


            //StartCoroutine("StopDoor");
            //KeyPad.SetActive(false);
            //Close.SetActive(false);
        }
        else
        {
            Ans.text = "";
            //KeyPad.SetActive(false);
            Wrong.Play();
        }
    }
    public void close()
    {
        KeyPad.SetActive(false);
        
    }

    /*IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.05f);
        DoorOp.SetBool("Open",false);
        DoorOp.enabled = false;
    }*/
}
