using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExample : MonoBehaviour
{
    public Transform objToFollow;
    private Vector3 deltaPos;
    // Start is called before the first frame update
    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }
}
