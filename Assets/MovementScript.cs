using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public GameObject objetoCamaraVR;
    public GameObject MercuryText;
    public GameObject VenusText;
    public GameObject EarthText;
    public GameObject MarsText;
    public GameObject JupiterText;
    public GameObject SaturnText;
    public GameObject UranusText;
    public GameObject NeptuneText;
    public GameObject SunText;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTRO!!!");
        Debug.Log("Encontro a: " + objetoCamaraVR.name);
        DesactiveText();
        if(other.tag == "Mercury")
        {
            //objetoTexto = GameObject.Find("MercuryText");
            MercuryText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(-107.5f, 1.6f, -64.2f);
        }
        if (other.tag == "Venus")
        {
            VenusText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(-131.9f, -3.3f, 18.3f);
        }
        if (other.tag == "Earth")
        {
            EarthText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(-251f, -3.3f, -13.3f);
        }
        if (other.tag == "Mars")
        {
            MarsText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(236.9f, -3.3f, 170.3f);
        }
        if (other.tag == "Jupiter")
        {
            JupiterText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(462.2f, -3.3f, -172.2f);
        }
        if (other.tag == "Saturno")
        {
            SaturnText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(505.1f, -3.3f, 199.1f);
        }
        if (other.tag == "Urano")
        {
            UranusText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(776.8f, 6f, 7.1f);
        }
        if (other.tag == "Neptuno")
        {
            NeptuneText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(932.96f, 6.3f, 262.15f);
        }
        if (other.tag == "Sun")
        {
            SunText.SetActive(true);
            objetoCamaraVR.transform.position = new Vector3(0f, 0f, -116.5f);
        }
    }

    void DesactiveText()
    {
        MercuryText.SetActive(false);
        VenusText.SetActive(false);
        EarthText.SetActive(false);
        MarsText.SetActive(false);
        JupiterText.SetActive(false);
        SaturnText.SetActive(false);
        UranusText.SetActive(false);
        NeptuneText.SetActive(false);
    }
}
