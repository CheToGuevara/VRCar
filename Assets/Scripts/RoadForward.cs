using UnityEngine;
using System.Collections;

public class RoadForward : MonoBehaviour {

    Road myRoad;
    //TrafficLight myTrafficLight;


	// Use this for initialization
	void Start () {
        myRoad = GameObject.Find("Road").GetComponent<Road>();
        //myTrafficLight = transform.parent.GetComponentInChildren<TrafficLight>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocado");
        Debug.Log(Time.time);
        //Debug.Log(this.transform.parent.name);
        GameObject.Find("Monitor").GetComponent<Monitoring>().EndofRoad();
        //myRoad.RoadForward();
        //myTrafficLight.setRed(true);


    }
}
