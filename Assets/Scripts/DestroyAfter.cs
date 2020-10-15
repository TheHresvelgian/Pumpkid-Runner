using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    
    void Start()
    {
        Invoke("Destroy", 5f);
    }

    private void Destroy()
    {
        Object.Destroy(this.gameObject);
    }
}
