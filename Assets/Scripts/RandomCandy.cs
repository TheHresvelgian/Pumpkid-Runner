using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RandomCandy : MonoBehaviour
{
    [SerializeField]
    private GameObject KvikkLunsj;
    // Start is called before the first frame update
    void Start()
    {
        SpawnKvikkLunsj();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnKvikkLunsj();
    }

    private void SpawnKvikkLunsj()
    {
        bool KvikkLunsjSpawned = false;
        while (!KvikkLunsjSpawned)
        {
            Vector3 KvikkLunsjPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((KvikkLunsjPosition - transform.position).magnitude < 3)
            {

            }
        }
    }    
}