using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{



    private Ray ray;
    public float rayDistance = 8;
    RaycastHit hit;



    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        CheckIfRayCastHit();
    }




    void CheckIfRayCastHit()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance, Color.black);



        if (Physics.Raycast(ray, out hit))
        {
            if (hit.distance < rayDistance)
            {
                print("we hit something");



                if (hit.collider.gameObject.tag == "Enemy")
                {
                    print("There is an enemy in range");



                    if (Input.GetKeyUp("space"))
                    {
                        print("Destroyed");
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }




    }



}