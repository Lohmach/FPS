using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class seller_script : MonoBehaviour
{
    public FirstPersonController fps;
	public GameObject boomstik;
	public GameObject rifle;
	public Texture2D Prodarec_texture;
	public bool a;
	public bool b;
	public int c = 0;

    void Update ()
    {

        if (Vector3.Distance (transform.position, fps.transform.position) <= 3)
        {
			a = true;
        }
        else
        {
			a = false;
		}
		if (Input.GetKeyDown (KeyCode.E))
        {
			b = true;
		}

	}

	void OnGUI()
    {
		if (a == true)
        {
			GUI.DrawTexture (new Rect ((Screen.width - 50) / 2, (Screen.height - 50) / 2, 50, 50), Prodarec_texture);
		}
		if (b == true)
        {
            boomstik.SetActive (false);
            rifle.SetActive (false);
			a = false;

			fps.enabled = false;
			GUI.Box (new Rect ((Screen.width - 350) / 2, (Screen.height - 450) / 2, 350, 450), "");

			if(GUI.Button(new Rect ((Screen.width - 150) / 2, (Screen.height - 30) / 2, 150, 40), "Rifle"))
			{
                c = 1;
				fps.enabled = true;
				a = true;
				b = false;
                rifle.SetActive (true);

			}

			if(GUI.Button(new Rect ((Screen.width - 150) / 2, (Screen.height - 120) / 2, 150, 40), "boomstick"))
            {
				c = 2;
				fps.enabled = true;
				a = true;
				b = false;
                boomstik.SetActive (true);
				

			}
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
		
		}


	}
}
