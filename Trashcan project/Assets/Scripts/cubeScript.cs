using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * x * speed * Time.deltaTime);
        transform.Translate(Vector3.back * z * speed * Time.deltaTime);
    }
}
