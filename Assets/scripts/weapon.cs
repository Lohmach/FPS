using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject boomstick;
    public GameObject rifle;


    public double delay_time_boomstick = 1.1;
    private bool delay_on = false;
    public Texture2D aim;
    public Texture2D aim_zoom;
    public GameObject bullet;
    public Transform position_generate_bullet;
    public GameObject Main_Camera;

    public AudioClip boom_sound;


    public bool zoom;

    void Start()
    {

        zoom = false;
    }

    void Update()
    {
        Animator animator = gameObject.GetComponent<Animator>();

        if (Input.GetMouseButtonDown(0) && delay_time_boomstick >= 1.1)
        {
            zoom = !zoom;
            if (zoom == true)
            {
                animator.Play("rifle_zoom");
                Main_Camera.GetComponent<Camera>().fieldOfView = 18;
            }
            if (zoom == false)
            {
                animator.Play("rifle_zoom_off");
                Main_Camera.GetComponent<Camera>().fieldOfView = 60;
            }


        }

        
        if (Input.GetMouseButtonDown(1) && delay_time_boomstick >= 1.1)
        {
            zoom = false;
            global_variables.ammo -= 1;
            Main_Camera.GetComponent<Camera>().fieldOfView = 60;

            GetComponent<AudioSource>().PlayOneShot(boom_sound);
            Instantiate(bullet, position_generate_bullet.transform.position, position_generate_bullet.rotation);
            animator.Play("MouseDownState");

            delay_time_boomstick = 0;
            delay_on = true;

        }

        if (delay_on == true)
        {
            delay_time_boomstick += Time.deltaTime;
            if (delay_time_boomstick >= 1.1)
            {
                delay_on = false;
            }

        }
    }
    void OnGUI()
    {
        if(zoom == false)
        {
            GUI.DrawTexture(new Rect((Screen.width - 25) / 2, (Screen.height - 25) / 2, 25, 25), aim);
        }
        if (zoom == true)
        {
            GUI.DrawTexture(new Rect(-10, 4, Screen.width, Screen.height), aim_zoom); //центрировал, для точности, но в итоге съехали бока(текстура не моя)
        }
    }
}