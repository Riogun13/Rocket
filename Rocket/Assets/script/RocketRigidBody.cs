using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRigidBody : MonoBehaviour {
    public Rigidbody rocketRigidBody;
    [SerializeField] public float ForceUpward = 2000;
    [SerializeField] public float Trust = 20;
    [SerializeField] public float pointForce = 2;
    // Use this for initialization
    void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        ManageInputVertivcal();
        ManageInputHorizontal();
    }

    private void ManageInputVertivcal()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddForce(new Vector3(0, ForceUpward, 0));
        }
    }

    private void ManageInputHorizontal()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(0, Trust, 0),(new Vector3(pointForce, 0, 0)));
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(0, -Trust, 0),(new Vector3(pointForce, 0, 0)));
        }
    }
}
