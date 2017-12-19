using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class end1 : MonoBehaviour
{
    public FirstPersonController fps1;
    CursorLockMode wantedMode;
    bool end_tr = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (global_variables.ammo == 0)
        {
            end_tr = true;
            fps1.enabled = false;
        }
    }

    void OnGUI()
    {
        if (end_tr == true)
        {
            
            Cursor.visible = true;
            Cursor.lockState = wantedMode = CursorLockMode.None;
            GUI.Box(new Rect((Screen.width - 350) / 2, (Screen.height - 450) / 2, 350, 450), "end");

            if (GUI.Button(new Rect((Screen.width - 150) / 2, (Screen.height - 30) / 2, 150, 40), "retry"))
            {
                end_tr = false;
                Cursor.visible = false;
                fps1.enabled = true;
                global_variables.ammo = 10;
                global_variables.total_Points = 0;
                global_variables.share = false;
            }

            if (GUI.Button(new Rect((Screen.width - 150) / 2, (Screen.height - 120) / 2, 150, 40), "Share"))
            {
                end_tr = false;
                Cursor.visible = false;
                fps1.enabled = true;
                global_variables.share = true;
            }
        }
        if(global_variables.share == true)
        {
            GUI.Box(new Rect((Screen.width - 100) / 2, (Screen.height - 275) / 2, 100, 75), "WIN!\n"+global_variables.total_Points.ToString());
        }
    }
}
