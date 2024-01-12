using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // cube speed 
    float speed = 5.0f; // 5 u/s
    float stepSpeed = 1.0f; // 1 u steps
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetAxis
        //float x = Input.GetAxis("Horizontal"); // -1.0..1.0
        //float y = Input.GetAxis("Vertical"); // -1.0..1.0
        
        // for DIAGONAL
        // .normalized

        //gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        //gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // translate = move/warp


        // WASD
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
            gameObject.transform.Translate(Vector3.forward * stepSpeed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
          gameObject.transform.Translate(Vector3.left * stepSpeed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * stepSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * stepSpeed);
        }

        // IJKL
        if (Input.GetKey(KeyCode.I)) 
        { 
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.J))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.K))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.L))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

    }
}
