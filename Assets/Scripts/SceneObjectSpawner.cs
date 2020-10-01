using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObjectSpawner : MonoBehaviour
{

    [SerializeField] GameObject[] _objects;
    private Vector3 _currentPos;

    // Start is called before the first frame update
    void Start()
    {
        _currentPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentPos != transform.position)
        {
            Instantiate(_objects[Random.Range(0, _objects.Length)], transform.position, Quaternion.identity);
            _currentPos = transform.position;
        }
    }
}
