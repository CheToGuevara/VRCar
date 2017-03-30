using UnityEngine;
using System.Collections;

public class Houses : MonoBehaviour {

    public GameObject[] m_Lhouses;
    public GameObject[] m_Rhouses;
    int current_Houses;


    Vector3 last_shift;

    public int[] Houseslentgh ={20};
    

	// Use this for initialization
	void Start () {

        last_shift = new Vector3(0, 0, 0);
        current_Houses = 0;

        HousesForward();
        
        if (m_Lhouses.Length != m_Rhouses.Length)
            Debug.LogError("LENGTH OF HOUSES DONT MATCH");
        //last_seconds = Housess.Length * Houseslentgh + Houseslentgh;
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void HousesForward()
    {
      
        //Debug.Log(this.transform.parent.name);
        current_Houses = (current_Houses + 1) % m_Lhouses.Length;
        last_shift += new Vector3(0, 0, Houseslentgh[current_Houses]);
        m_Lhouses[current_Houses].transform.transform.localPosition = last_shift;// + new Vector3(0,0, Houseslentgh[current_Houses]);
        //m_Lhouses[current_Houses].transform.Translate(0, -100, );


        m_Rhouses[current_Houses].transform.transform.localPosition = last_shift;// + new Vector3(0, 0, Houseslentgh[current_Houses]);

        //m_Rhouses[current_Houses].transform.Translate(0, 0, Houseslentgh[current_Houses]);



    }
}
