using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAggression : MonoBehaviour
{
    Rigidbody rb;
    public Transform player;
    public float hungerForce = 30f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerDirection = Vector3.Normalize(player.position - transform.position);

        rb.AddForce(playerDirection * hungerForce);
    }
}
