using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonLoad : MonoBehaviour
{
    public void Click ()
    {
        Invoke("Destroy", 1f);
    }
    public void Destroy()
    {
        
        Destroy(this.gameObject);
    }
}
