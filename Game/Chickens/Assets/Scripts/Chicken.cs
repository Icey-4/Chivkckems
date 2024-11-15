using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Chicken : MonoBehaviour
{
    public Vector3 target;
    public float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Barm")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Evil")
        {
            Destroy(gameObject);
        }
    }
}
