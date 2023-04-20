using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float prevTime;
    public float waitTime = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - prevTime) > waitTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            prevTime = Time.time;
        }
    }
}
