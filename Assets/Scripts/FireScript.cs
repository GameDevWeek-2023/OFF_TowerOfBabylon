using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance?.Play("Fire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
