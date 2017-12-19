using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class esc_menu : MonoBehaviour
{
    public FirstPersonController fps;
    CursorLockMode wantedMode;
    bool a = false;
    bool end = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            a = !a;
            fps.enabled = !fps.enabled;
        }
        
    }
    void OnGUI()
    {
        if(a == true)
        {
            Cursor.visible = true;
            Cursor.lockState = wantedMode = CursorLockMode.None;
            GUI.Box(new Rect((Screen.width - 350) / 2, (Screen.height - 450) / 2, 350, 450), "");

            if (GUI.Button(new Rect((Screen.width - 150) / 2, (Screen.height - 30) / 2, 150, 40), "Speed 1"))
            {
                a = false;
                Cursor.visible = false;
                fps.enabled = !fps.enabled;
                global_variables.speed = 1;
            }

            if (GUI.Button(new Rect((Screen.width - 150) / 2, (Screen.height - 120) / 2, 150, 40), "Speed 2"))
            {
                a = false;
                Cursor.visible = false;
                fps.enabled = !fps.enabled;
                global_variables.speed = 2;
            }
            if (GUI.Button(new Rect((Screen.width - 150) / 2, (Screen.height - 210) / 2, 150, 40), "Speed 3"))
            {
                a = false;
                Cursor.visible = false;
                fps.enabled = !fps.enabled;
                global_variables.speed = 3;
            }

        }
        GUI.Label(new Rect(10, 10, 100, 20), global_variables.total_Points.ToString());
        GUI.Label(new Rect(10, Screen.height -20, 100, 20), global_variables.ammo.ToString()+ "/10");


    }
}

