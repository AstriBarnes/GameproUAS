using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    public GameObject ground;
    // Start is called before the first frame update

    void Update()
    {
        if(time<=0)
        {
            Instantiate(ground, transform.position, Quaternion.identity);
            time= timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
