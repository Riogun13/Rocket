using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRigidBody : MonoBehaviour {
    public Rigidbody rocketRigidBody;
    [SerializeField] public float ForceUpward = 2000;
    // Use this for initialization
    void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddForce(new Vector3(0, ForceUpward, 0));
        }
    }
}
