using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compressAnim : MonoBehaviour
{
    public Animator Anim1;
    public Animator Anim2;
    public Animator Anim3;
    public void pressedCompression()
    {
        Debug.Log("pressed button.....");

        Anim1.SetTrigger("compressmac");
        Anim2.SetTrigger("compressmat");
        Anim3.SetTrigger("down");
    }
}
