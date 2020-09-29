using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private int _speed = 4;
    private Rigidbody2D _rigdigBody;
    private Vector2 _moveVector;
    public int constantSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        _rigdigBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveVector.y = Input.GetAxisRaw("Vertical");
        Vector3 characterScale = transform.localScale;


    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            constantSpeed = 2;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            constantSpeed = 6;
        }
        else
        {
            constantSpeed = 4;
        }
        _rigdigBody.velocity = new Vector2(constantSpeed, _moveVector.y * _speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            new Vector2(0f, 0f);
        }
    }
}
