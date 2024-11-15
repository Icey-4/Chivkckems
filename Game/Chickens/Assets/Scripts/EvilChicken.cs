using UnityEngine;

public class EvilChicken : MonoBehaviour
{
    public float speed = 0.2f;
    public Vector3 target;
    public Vector3 targetTwo;
    bool swap;
    public bool kill;


    // Use this for initialization
    void Start()
    {
        target = new Vector3(-20.0f, 0.88f, 0.88f);
        targetTwo = new Vector3(20.0f, 0.88f, 0.88f);
    }
    void Update()
    {

        if (transform.position == target)
        {
            swap = true;
        }

        if (transform.position == targetTwo)
        {
            swap = false;
        }

        if (swap)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetTwo, speed);
        }

        if (!swap)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed);
        }
    }

    public void Die()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }

}




