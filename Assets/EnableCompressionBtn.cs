using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnableCompressionBtn : MonoBehaviour
{
    public GameObject nextbutton;
    public GameObject error;

    public compressAnim compressionmachinescript;
    void Update()
    {
        if (compressionmachinescript.iscompressiontest)
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
