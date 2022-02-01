using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{

    public float force;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb;
        playerRb = other.GetComponent<Rigidbody>();
        if (playerRb.CompareTag("Player"))
        {
            playerRb.AddForce(transform.up * force);
        }
    }
}
