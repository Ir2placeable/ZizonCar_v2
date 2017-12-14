using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTank_Bulley : MonoBehaviour {

    private Rigidbody vehicleRigidbody = null;
    public float bulletSpeed = 0.0f;

	// Use this for initialization
	void Start () {
        vehicleRigidbody = gameObject.GetComponent<Rigidbody>();

        vehicleRigidbody.AddRelativeForce(Vector3.forward * bulletSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Vehicle"))
        {
            VehicleControl control = col.gameObject.GetComponent<VehicleControl>();

            if (control.vehicleID == 0)
            {
                GameManager.Instance().p1WinCount = 1;
            }
            else
            {
                GameManager.Instance().p2WinCount = 1;
            }
        }

        Destroy(gameObject);
    }
}
