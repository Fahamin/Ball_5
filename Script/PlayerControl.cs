using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public bool ply=true;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
      // transform.Translate(0, 0, 50* Time.smoothDeltaTime);
        //transform.Rotate(100, 0, 0);
        GameManager.instance.scoreCounter += Time.deltaTime * 10;
        GameManager.instance.SpeedCounter += Time.deltaTime * 10;

        transform.Translate(Input.acceleration.x*110f * Time.smoothDeltaTime, 0f, 0f );
        if (transform.position.y< 10)
        {
            gameOver();
            // SceneManager.LoadScene(0);
        }
        if (transform.position.x == 20 || transform.position.x==-20)
        {
            gameOver();
            // SceneManager.LoadScene(0);
        }
        

        if (Input.GetKey("a"))
        {
            transform.Translate(-50 * Time.smoothDeltaTime, 0, 0);
        }

        if (Input.GetKey("d")) 
        {
            
            transform.Translate(50 * Time.smoothDeltaTime, 0,0);
        }


        if (Input.GetKey("s"))
        {

           // transform.Translate(0, 50 * Time.smoothDeltaTime, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       if( collision.gameObject.CompareTag("enemy"))
        {
            gameOver();
        }
    }


    public void gameOver()
    {
        GameManager.instance.GameOver();
        GameManager.instance.ParticleInstFun(this.transform);
        AudioManager.instance.destroy();
        AudioManager.instance.bg = true;
        EnviromentPartical.instance.destroyPratical();
        Handheld.Vibrate();
        Destroy(this.gameObject);

    }
}
