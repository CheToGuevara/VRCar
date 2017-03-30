using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Monitoring : MonoBehaviour {

    bool recording;
    public bool end= false;
    string username;
    int seconds;
    int stopping;
    int acceleration;
    int timedown = 3;

    public GameObject ExplainCanvas;
    public GameObject CountDownCanvas;
    public Text CountText;
    public GameObject RoadGO;

    System.IO.FileStream oFileStream = null;

	// Use this for initialization
	void Start () {
        recording = false;
        username = "TestUser";
        seconds = 3;
        stopping = 0;
        acceleration = 1;
        end = false;

	}
	
	// Update is called once per frame
	void Update () {

        if (!recording)
        {
            return;
        }

        string line = "";

        line=string.Concat(line, System.DateTime.Now.ToString("hh mm ss ff "));
        line = string.Concat(line, username);
        line = string.Concat(line, " ");
        line = string.Concat(line, Time.time);
        line = string.Concat(line, " ");
        line = string.Concat(line, Time.deltaTime);
        line = string.Concat(line, " ");
        line = string.Concat(line, Input.GetAxis("Vertical"));
        line = string.Concat(line, " ");
        line = string.Concat(line, 0);
        line = string.Concat(line, " ");
        line = string.Concat(line, acceleration);
        line = string.Concat(line, " ");
        line = string.Concat(line, stopping);
        line = string.Concat(line, " ");
        line = string.Concat(line, seconds);
        //line = string.Concat(line, Time.deltaTime);



        //Debug.Log("Linea a escribir");
        //Debug.Log(line);
        line = string.Concat(line, "\n");
        oFileStream.Write(System.Text.Encoding.UTF8.GetBytes (line), 0, line.Length);


        if (end)
        {
            recording = false;
            oFileStream.Close();
        }

	
	}

    public void OnClickStart()
    {
        Debug.Log("Pulsada");
        ExplainCanvas.SetActive(false);
        CountDownCanvas.SetActive(true);
        InvokeRepeating("Countdown", 1,1);
    }

    public void EndofRoad()
    {
        seconds = Random.Range(1,4);
        RoadGO.GetComponent<Road>().RoadForward(seconds);
    }

    void Countdown()
    {

        Debug.Log("Llamada cuenta");
        timedown--;
        CountText.text = timedown.ToString(); 
        if (timedown == 0)
        {

            
            oFileStream = new System.IO.FileStream("D:\\"+username+".txt", System.IO.FileMode.Create);
            CancelInvoke();
            CountDownCanvas.SetActive(false);
            recording = true;
        }
    }


}
