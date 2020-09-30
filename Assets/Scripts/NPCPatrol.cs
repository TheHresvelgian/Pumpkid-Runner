using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPatrol : MonoBehaviour
{

    private Rigidbody2D _rigidBody;
    private float _speed = 5f;
    private float _direction;
    private float _negativeDir = -1f;
    private float _positiveDir = 1f;

    [SerializeField] private bool _directionBool = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _direction = _negativeDir;
    }

    // Update is called once per frame
    void Update()
    {
        if (_directionBool)
        {
            // Vertical movement
            _rigidBody.velocity = new Vector3(0f, _direction * _speed, 0f);
        }
        else
        {
            // Horizontal Movement
            _rigidBody.velocity = new Vector3(_direction * _speed, 0f, 0f);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Flip"))
        {
            if (_direction < 0)
            {
                _direction = _positiveDir;
            }
            else { _direction = _negativeDir;  }

            transform.localScale = new Vector3(_direction, 1, 1);
        }
    }
}
