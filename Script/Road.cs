using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{

    public bool ply=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ply == true)
        {
            transform.Translate(0, 0,- 50 * Time.smoothDeltaTime);
        }

        if (transform.position.z <584)
        {
            ply = false;
        }
    }
}
