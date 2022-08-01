using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mercury.transform.Rotate(0, 0.02f, 0, Space.World);
        Venus.transform.Rotate(0, 0.03f, 0 ,Space.World);
        Earth.transform.Rotate(0, 0.025f, 0,Space.World);
        Mars.transform.Rotate(0, 0.02f, 0,Space.World);
        Jupiter.transform.Rotate(0, 0.05f, 0,Space.World);
        Saturn.transform.Rotate(0, 0.1f, 0,Space.World);
        Uranus.transform.Rotate(0, 0.015f, 0,Space.World);
        Neptune.transform.Rotate(0, 0.01f, 0 ,Space.World);
    }
}
