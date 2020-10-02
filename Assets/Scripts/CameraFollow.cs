using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
    }
    public Transform target;
    public float smoothTime = 0f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private float _yAxis = 0;
    [SerializeField] private float _xAlteration = 0;

    void Update()
    {

        // Smoothly move the camera towards that target position
        transform.position = new Vector3(target.position.x + _xAlteration, _yAxis, -30f);
    }
}
