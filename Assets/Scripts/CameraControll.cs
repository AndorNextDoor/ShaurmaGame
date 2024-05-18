using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class CameraControll : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 targetOffset;
    [SerializeField]
    private float movementSpeed;
    // public Transform player;

    // Update is called once per frame
    void Update()
    {
        MovementInput();
    }


    void MovementInput()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + targetOffset, movementSpeed * Time.deltaTime);
    }

    
    // void MovementCamera()
    // {
    //     transform.position = player.transform.position + new Vector3(0, 15, -8);
    //     Camera.main.transform.rotation = Quaternion.Euler(60, 0, 0);
    // }
}
