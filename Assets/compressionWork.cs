using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compressionWork : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject compressionPlacedUI;
    public GameObject CompressionNotUI;
    public GameObject compressionMaterial;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("material2"))
        {
            compressionMaterial.gameObject.SetActive(true);
            CompressionNotUI.gameObject.SetActive(false);
            compressionPlacedUI.SetActive(true);
        }

    }
}
