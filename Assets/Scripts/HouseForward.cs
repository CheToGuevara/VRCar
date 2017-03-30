using UnityEngine;
using System.Collections;

public class HouseForward : MonoBehaviour {

    Houses myHouse;
    //TrafficLight myTrafficLight;


	// Use this for initialization
	void Start () {
        myHouse = GameObject.Find("Houses").GetComponent<Houses>();
        //myTrafficLight = transform.parent.GetComponentInChildren<TrafficLight>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {

        //GameObject.Find("Monitor").GetComponent<Monitoring>().EndofRoad();
        myHouse.HousesForward();
        //myRoad.RoadForward();
        //myTrafficLight.setRed(true);


    }
}
