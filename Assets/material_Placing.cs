using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class material_Placing : MonoBehaviour
{
    public GameObject tensilePlacedUI;
    public GameObject tensileNotUI;
    public GameObject tensilecommon;
    public GameObject tensilebreak;
    public GameObject tensilenot;
    public GameObject resultUI;
    public GameObject resultUIbreak;

    public TextMeshProUGUI result;
    public TextMeshProUGUI resultbreak;



    public machineWork machineanimationTrigger;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("common"))
        {
            machineanimationTrigger.setMaterial(1);
            tensilecommon.gameObject.SetActive(true);
            tensilebreak.gameObject.SetActive(false);
            tensilenot.gameObject.SetActive(false);
            tensileNotUI.gameObject.SetActive(false);
            tensilePlacedUI.SetActive(true);
            
            result.text = "Material Strength 10 KN";
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("break"))
        {
            machineanimationTrigger.setMaterial(2);
            tensilecommon.gameObject.SetActive(false);
            tensilebreak.gameObject.SetActive(true);
            tensilenot.gameObject.SetActive(false);
            tensileNotUI.gameObject.SetActive(false);
            tensilePlacedUI.SetActive(true);
           
            result.text = "Material Strength 20 KN";
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("not"))
        {
            machineanimationTrigger.setMaterial(3);
            tensilecommon.gameObject.SetActive(false);
            tensilebreak.gameObject.SetActive(false);
            tensilenot.gameObject.SetActive(true);
            tensileNotUI.gameObject.SetActive(false);
            tensilePlacedUI.SetActive(true);

            resultbreak.text = "Material Strength 0 KN";
        }

      
    }
    public void showresultUIbreak()
    {
        resultUIbreak.SetActive(true);
    }
    public void showresultUI()
    {
        resultUI.SetActive(true);
    }
    public void disableplacedUI()
    {
        tensilePlacedUI.SetActive(false);
    }

    public void Reset()
    {
        tensilePlacedUI.SetActive(false);
        tensileNotUI.gameObject.SetActive(true);
        resultUI.SetActive(false);
        resultUIbreak.SetActive(false);
        tensilecommon.gameObject.SetActive(false);
        tensilebreak.gameObject.SetActive(false);
        tensilenot.gameObject.SetActive(false);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
