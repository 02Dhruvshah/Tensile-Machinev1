using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class machineWork : MonoBehaviour
{
    public Animator machine;
    public Animator tensilecommon;
    public Animator tensilebreak;
    public Animator tensilenot;
    public Animator button;

    public Animator machineup;

    public bool common = false;
    public bool breaking = false;
    public bool notanim = false;

    public material_Placing placingScript;

    public bool isTensile_machine_commontested = false;
    public bool isTensile_machine_breaktested = false;
    public bool isTensile_machine_normaltested = false;
    private void Start()
    {
        machineup = GetComponent<Animator>();
        //Anim3 = GetComponent<Animator>();
        //Anim1 = GetComponent<Animator>();
        //Anim2 = GetComponent<Animator>();

    }
    public void setMaterial(int value)
    {
        if(value == 1)
        {
            common = true;
        }
        else if(value == 2)
        {
            breaking = true;
        }
        else 
        {
            notanim = true;
            Debug.Log("Setted value as true");
        }

    }
    public void pressed()
    {
        Debug.Log("pressed button.....");
        if(common)
        {
            Debug.Log(" animie 1");
            machineup.GetComponent<Animator>().enabled = true;
            button.SetTrigger("down");
            machine.SetTrigger("upward");
            tensilecommon.SetTrigger("tensileup");
            placingScript.disableplacedUI();
            placingScript.showresultUI();
            notanim = false;
            breaking = false;
            common = false;
            isTensile_machine_commontested = true;
        }
        else if(breaking)
        {
            Debug.Log(" animie 2");
            machineup.GetComponent<Animator>().enabled = true;
            button.SetTrigger("down");
            tensilebreak.SetTrigger("tensileupbreak");
            machine.SetTrigger("break");
            placingScript.disableplacedUI();
            placingScript.showresultUIbreak();
            notanim = false;
            breaking = false;
            common = false;
            isTensile_machine_breaktested = true;
        }
        //else if(not)
        else if (notanim) 
        {
            Debug.Log("not animie");
            //machineup.GetComponent<Animator>().enabled = false;
            button.SetTrigger("down");
            machineup.SetTrigger("notAnim");
            placingScript.disableplacedUI();
            placingScript.showresultUI();
            notanim = false;
            breaking = false;
            common = false;
            isTensile_machine_normaltested=true;
        }
        else
        {
            return;
        }
      
    }
 
    public void stoppressed()
    {
        Debug.Log("Stop button presses");
        button.SetTrigger("release");
        machine.SetTrigger("idle");
        placingScript.Reset();
    }
}
