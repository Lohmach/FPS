using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//11
public class AI_enemy1 : MonoBehaviour
{
    private Transform myTransform;
    public Transform Pers;

    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public Transform Point4;

    public Transform[] traetrajectory = new Transform[4];

    public float From_enemy_to_player;
    public float From_enemy_to_point;

    public int i;

    void Start ()
    {
        Pers = global_variables.Pers;
        Point1 = global_variables.Point1;
        Point2 = global_variables.Point2;
        Point3 = global_variables.Point3;
        Point4 = global_variables.Point4;
        i = 0;
        traetrajectory[0] = Point1; // немного по китайски...
        traetrajectory[1] = Point2;
        traetrajectory[2] = Point3;
        traetrajectory[3] = Point4;

        myTransform = transform;
        i = Random.Range(0, 3);
	}
	
	void Update ()
    {
        From_enemy_to_player = Vector3.Distance(myTransform.transform.position, Pers.transform.position);
        From_enemy_to_point = Vector3.Distance(myTransform.transform.position, traetrajectory[i].transform.position);

        if (global_variables.enemy1_hp <= 0)
        {
            Destroy(gameObject);
            global_variables.total_Points += From_enemy_to_player * global_variables.speed;
            global_variables.enemy1_hp = 1;
        }
        
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(traetrajectory[i].position - myTransform.position), 20 * Time.deltaTime);
        myTransform.position += myTransform.forward * 10 * Time.deltaTime * global_variables.speed;

        if (From_enemy_to_point < 15)
        {
            Destroy(gameObject);   
        }

    }
}
