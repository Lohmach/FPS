using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public Transform Point4;
    private Transform[] Points = new Transform[4];

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    private double delay_spawn1 = 6;
    private double delay_spawn2 = 12;
    private double delay_spawn3 = 18;
    int i;

    // Use this for initialization
    void Start ()
    {
        Points[0] = Point1; // немного по китайски...
        Points[1] = Point2;
        Points[2] = Point3;
        Points[3] = Point4;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(delay_spawn1 >= 6 / global_variables.speed)
        {
            i = Random.Range(0, 3);
            Instantiate(enemy1, Points[i].transform.position, Points[i].rotation);
            delay_spawn1 = 0;
        }
        if (delay_spawn2 >= 12 / global_variables.speed)
        {
            i = Random.Range(0, 3);
            Instantiate(enemy2, Points[i].transform.position, Points[i].rotation);
            delay_spawn2 = 0;
        }
        if (delay_spawn3 >= 18 / global_variables.speed)
        {
            i = Random.Range(0, 3);
            Instantiate(enemy3, Points[i].transform.position, Points[i].rotation);
            delay_spawn3 = 0;
        }
        delay_spawn1 += Time.deltaTime;
        delay_spawn2 += Time.deltaTime;
        delay_spawn3 += Time.deltaTime;
    }
}
