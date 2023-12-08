using System.Collections;
using UnityEngine;

public class UI_control : MonoBehaviour
{
    public GameObject[] stepCanvases; // An array to hold all your step canvases
    public float canvasDistance = 2.0f; // Adjust the distance from the camera
    public Vector3 canvasOffset = Vector3.zero; // Adjust the offset relative to the camera
    public GameObject mainCanvas;
    private int currentStep = 0;
    private bool Glass, coat;

    public GameObject welcomeUI;
    public GameObject infoUI;
    public GameObject mainUi;
    //private bool doOnce =false;

    public machineWork machineanimationTrigger;
    public compressAnim compressionmachinescript;
    private void Start()
    {
        ShowStep(0); // Start with the first step (index 0)
        //mainCanvas.SetActive(true);
    }

    private void ShowStep(int step)
    {
        // Disable all canvases
        foreach (var canvas in stepCanvases)
        {
            canvas.SetActive(false);
        }

        // Enable the canvas for the given step
        if (step >= 0 && step < stepCanvases.Length)
        {

            stepCanvases[step].SetActive(true);
            if(!mainCanvas.activeInHierarchy)
            {
                mainCanvas.SetActive(true);
            }
        }

        currentStep = step;
    }

    //private void Update()
    //{
    //    if(!doOnce)
    //    StartCoroutine(turnoff());

    //}

    //IEnumerator turnoff()
    //{
    //    doOnce =true;
    //    yield return new WaitForSeconds(8);
    //    welcomeUI.SetActive(false);
    //    infoUI.SetActive(true);
    //    yield return new WaitForSeconds(8);
    //    infoUI.SetActive(false);
    //    mainUi.SetActive(true);
    //}
    private GameObject GetCurrentCanvas()
    {
        if (currentStep >= 0 && currentStep < stepCanvases.Length)
        {
            return stepCanvases[currentStep];
        }

        return null;
    }

    public void NextStep()
    {
        // Advance to the next step or end the sequence if there are no more steps
        if (currentStep < stepCanvases.Length - 1)
        {
            ShowStep(currentStep + 1);
        }
        else
        {
            // End of the sequence, you can handle this as needed
            Debug.Log("Sequence completed.");
        }
    }
    public void Step(int Obj)
    {
        if(Obj == 0)
        {
            Glass = true;
        }
        else
        {
            coat = true;
        }
    }
    public void StepController()
    {
        if(Glass && coat)
        {
            NextStep();
        }
    }
    public void quit()
    {
        if (compressionmachinescript.iscompressiontest && machineanimationTrigger.isTensile_machine_commontested && machineanimationTrigger.isTensile_machine_breaktested && machineanimationTrigger.isTensile_machine_normaltested)
        {
            Application.Quit();
        }
        else
        {
            Debug.Log("you are not tested the tensile machine");
        }

    }
}
