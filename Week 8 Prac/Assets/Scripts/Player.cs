using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed = 2;
    public Transform player1;
    public Transform player2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //movement
        if(Input.GetAxis("Horizontal") !=0 || Input.GetAxis("Vertical") !=0 )
        {
            float dx = Input.GetAxis("Horizontal");
            float dz = Input.GetAxis("Vertical");

            Vector3 velocity = new Vector3(dx, 0, dz) * playerSpeed;
            player2.Translate(velocity * Time.deltaTime);
        }
        if (Input.GetAxis(InputAxes.HorizontalMovement) != 0 || Input.GetAxis(InputAxes.LongitudinalMovement) != 0)
        {

            float dx = Input.GetAxis(InputAxes.HorizontalMovement);
            float dz = Input.GetAxis(InputAxes.LongitudinalMovement);

            Vector3 velocity = new Vector3(dx, 0, dz) * playerSpeed;
            player1.Translate(velocity * Time.deltaTime);
        }



    }



}
