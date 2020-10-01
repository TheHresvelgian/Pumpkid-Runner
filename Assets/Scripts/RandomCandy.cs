using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class RandomCandy : MonoBehaviour
{
    public static bool KvikkLunsjOnScreen = false;


    [SerializeField]
    public GameObject KvikkLunsj;
    // Start is called before the first frame update
    void Start()
    {
        SpawnKvikkLunsj();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!KvikkLunsjOnScreen)
        {
            SpawnKvikkLunsj();
        }
    }

    private void SpawnKvikkLunsj()
    {
        bool KvikkLunsjSpawned = false;
        while (!KvikkLunsjSpawned)
        {
            Vector3 KvikkLunsjPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f) + transform.position +(Vector3.right * 14);
            if ((KvikkLunsjPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(KvikkLunsj, KvikkLunsjPosition, Quaternion.identity);
                KvikkLunsjSpawned = true;
            }
        }
    }    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SpawnKvikkLunsj();
    }
}