using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawn : MonoBehaviour {

    public GameObject[] vehiclePrefab = null;
    public GameObject[] spawnZone = null;

    private GameObject playZone = null;

	// Use this for initialization
	void Start () {
        playZone = GameObject.Find("PlayZone");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private GameObject CreateVehicle(int vehicleIndex)
    {
        GameObject createdVehicle = Instantiate(vehiclePrefab[vehicleIndex], spawnZone[vehicleIndex].transform.position, spawnZone[vehicleIndex].transform.rotation, playZone.transform);
        return createdVehicle;
    }


    public void Spawn()
    {
        for (int i = 0; i < 2; i++)
        {
            VehicleControl spawnedVehicle = CreateVehicle(i).GetComponent<VehicleControl>();
            spawnedVehicle.vehicleID = i;
        }
            
    }
}
