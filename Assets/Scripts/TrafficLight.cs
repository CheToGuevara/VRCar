using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour {

    public GameObject[] m_object2change;

    public Material red_light;
    public Material yellow_light;
    public Material green_light;

    public int j = 0;
   

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        switch(j)
        {
            case 0:
                setGreen();
                break;
            case 1:
                setYellow();
                break;
            case 2:
                setRed();
                break;

        }
	
	}


    public void setRed()
    {
        for (int i = 0; i < m_object2change.Length; i++)
        {
            m_object2change[i].GetComponent<Renderer>().material = red_light;

        }
    }

    public void setYellow()
    {
        for (int i = 0; i < m_object2change.Length; i++)
        {
            m_object2change[i].GetComponent<Renderer>().material = yellow_light;

        }
    }

    public void setGreen()
    {
       for (int i=0; i < m_object2change.Length;i++)
        {
            m_object2change[i].GetComponent<Renderer>().material = green_light;

        }
    }



}
