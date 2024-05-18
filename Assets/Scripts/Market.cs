using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
