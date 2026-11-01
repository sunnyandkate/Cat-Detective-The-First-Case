using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    Vector3 camPos;
    public float smoothRate;
    // Start is called before the first frame update
    void Start()
    {
         camPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate(){
         Vector3 playerPos = player.transform.position;

        camPos = transform.position;
        camPos.x = Mathf.Lerp(camPos.x, playerPos.x, smoothRate);
        camPos.y = Mathf.Lerp(camPos.y, playerPos.y, smoothRate);

      

        transform.position = camPos;
    }
}
