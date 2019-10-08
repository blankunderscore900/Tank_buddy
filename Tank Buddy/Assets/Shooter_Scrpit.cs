using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Scrpit : MonoBehaviour
{

    GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = Resources.Load("bullet") as GameObject; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(gun) as GameObject;
            bullet.transform.position = transform.position + Camera.main.transform.right * 1;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.right * 40;
        }
    }

}
