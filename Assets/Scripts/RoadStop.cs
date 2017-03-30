using UnityEngine;
using System.Collections;

public class HouseStop : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Para");
        Car myCar = GameObject.Find("Coche").GetComponent<Car>();
        myCar.Stopped = false;

        

    }
}
