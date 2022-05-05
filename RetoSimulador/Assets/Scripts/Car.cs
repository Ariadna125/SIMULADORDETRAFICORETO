using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Range(1f, 10f)] public float moveSpeed = 1f; // Velocidad de movimiento del carro
    private Vector3 startPosition; // Punto de partida
    public Vector3 targetPosition; // Punto final
    private bool movingToTarget;

    // Start is called before the first frame update
    void Start()
    {
        //transform.LookAt(new Vector3(target.position.x, transform.position.y, transform.position.z));
        startPosition = transform.position;
        movingToTarget = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToTarget == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                movingToTarget = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);
            if (transform.position == startPosition)
            {
                movingToTarget = true;
            }
        }
    }
}

/*
   Update is called once per frame
   void Update()
   {
       transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
   }

   void OnTriggerEnter(Collider other)
   {
       if (other.tag == "Waypoint")
       {
           target = other.gameObject.GetComponent<WayPoint>().nextPoint;
           transform.LookAt(new Vector3(target.position.x, target.position.y, transform.position.z));
       }
   }*/
