using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {

    public GameObject[] roads;
    public GameObject[] stoproad;
    int current_road;
    int current_stop;

    Vector3 last_shift;

    public int roadlentgh = 20;
    

	// Use this for initialization
	void Start () {

        last_shift = new Vector3(0, 0, 0);
        current_road = 0;
        current_stop = 0;
        RoadForward(4);
        RoadForward(2);

        //last_seconds = roads.Length * roadlentgh + roadlentgh;
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void RoadForward(int seconds)
    {
        Debug.Log(seconds);
        for (int i = 0; i < seconds;i++ )
        {
            roads[current_road].transform.transform.localPosition = last_shift;
            roads[current_road].transform.Translate(0, 0, roadlentgh * i);
            current_road = (current_road + 1) % roads.Length;
        }
        
        stoproad[current_stop].transform.localPosition = last_shift;
        stoproad[current_stop].transform.Translate(0, 0, roadlentgh * seconds);
        last_shift = stoproad[current_stop].transform.localPosition + new Vector3(0, 0, roadlentgh);
        current_stop = (current_stop + 1) % stoproad.Length;

        
            
        

    }
}
