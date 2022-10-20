using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skr1 : MonoBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
          transform.position += speed *transform.forward* Time.deltaTime;
        }
         if (Input.GetKey(KeyCode.DownArrow))
         {
          transform.position += speed * Vector3.down * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.A))
         {
          transform.Rotate(transform.forward, rotationSpeed* Time.deltaTime)
         }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down, 5f);
        }
    }
}
