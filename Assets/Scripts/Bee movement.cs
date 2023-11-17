using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public float speed = 0;
    public float rotat = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed;
        transform.Rotate(transform.rotation.x, Random.Range(-30.0f, 30.0f), transform.rotation.z);
    }
}
