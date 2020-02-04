using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl  : MonoBehaviour
{
    public static CameraControl instance;
    public GameObject Player;
    public Vector3 offset;
    public bool destroy = true;
    public int color = 0;
   
    public Camera cam;
    public Color backgroundColor { get; private set; }
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public Color color3 = Color.blue;
    public Color color4 = Color.blue;
    public Color color5 = Color.blue;
    public Color color6 = Color.blue;
    public Color color7 = Color.blue;

    
   



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        offset = transform.position - Player.transform.position;

        cam = GetComponent<Camera>();
       
        color = Random.Range(0, 7);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (null != Player)
        {
            transform.position = Player.transform.position + offset;
        }

      /*if (destroy==false)
        {
            if (tim < 0)
            {
                GameManager.instance.GamePanel();
                transform.Translate(-13, 0, 0);
                destroy = true;
            }
            else
            {
                tim --;
            }
        }
        */
    }

    private void FixedUpdate()
    {
        switch (color)
        {
            case 0:
                cam.backgroundColor = color1;
                break;
            case 1:
                cam.backgroundColor = color2;
                break;
            case 2:
                cam.backgroundColor = color3;
                break;
            case 3:
                cam.backgroundColor = color4;
                break;
            case 4:
                cam.backgroundColor = color5;
                break;
            case 5:
                cam.backgroundColor = color6;
                break;
            case 6:
                cam.backgroundColor = color7;
                break;
            
        }
    }
}
