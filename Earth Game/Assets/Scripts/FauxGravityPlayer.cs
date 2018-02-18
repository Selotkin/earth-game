using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityPlayer : MonoBehaviour {

    public FauxGravity fauxGravity;

    private Transform myTransform;
    private Rigidbody myRigidbody;
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        myRigidbody.useGravity = false;
        myTransform = transform;
    }

    private void Update()
    {
        fauxGravity.Attract(myRigidbody);
    }
}
