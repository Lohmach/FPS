using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global_variables : MonoBehaviour
{
    public Transform pPers;
                     
    public Transform pPoint1;
    public Transform pPoint2;
    public Transform pPoint3;
    public Transform pPoint4;

    public static Transform Pers;

    public static Transform Point1;
    public static Transform Point2;
    public static Transform Point3;
    public static Transform Point4;

    public static float speed = 1;

    public static float enemy1_hp = 1;
    public static float enemy2_hp = 1;
    public static float enemy3_hp = 1;

    public static int ammo = 10;

    public static float total_Points;

    public static bool share = false;

    void Start ()
    {
        Pers = pPers;
        Point1 = pPoint1;
        Point2 = pPoint2;
        Point3 = pPoint3;
        Point4 = pPoint4;
        total_Points = 0;
    }
}
