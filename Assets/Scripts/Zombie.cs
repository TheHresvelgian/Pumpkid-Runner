using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform[] patrol;
    private int Currentpoint;
    public float moveSpeed; public float rotateSpeed = 2.0f;

    private bool rotating;

    void Update()
    {
        StartCoroutine(TurnTowards(-transform.forward));
    }

    IEnumerator TurnTowards(Vector3 lookAtTarget)
    {

        if (rotating == false)
        {
            //Vector3 direction = lookAtTarget - transform.position;//this can be deleted, it's never used :P
            Quaternion newRotation = Quaternion.LookRotation(lookAtTarget - transform.position);
            newRotation.x = 0;
            newRotation.z = 0;

            for (float u = 0.0f; u <= 1.0f; u += Time.deltaTime * rotateSpeed)
            {
                rotating = true;
                transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, u);

                yield return null;
            }
            rotating = false;
        }
    }
}
