using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChicken : MonoBehaviour
{
    public GameObject chick;
    public GameObject evilChick;
    int evil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int evil = Random.Range(1, 50);
            if (evil == 2) { Instantiate(evilChick); }
            else { Instantiate(chick); }
        }
    }
}
