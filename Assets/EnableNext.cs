using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableNext : MonoBehaviour
{
    public GameObject nextbutton;
    public GameObject error;

    public machineWork machineanimationTrigger;
    
    private void Update()
    {
        if (machineanimationTrigger.isTensile_machine_commontested && machineanimationTrigger.isTensile_machine_breaktested && machineanimationTrigger.isTensile_machine_normaltested)
        {
            error.SetActive(false);
            nextbutton.SetActive(true);
        }
        else
        {
            nextbutton.SetActive(false);
            error.SetActive(true);

        }
    }
  
}
