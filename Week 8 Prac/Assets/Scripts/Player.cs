using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed = 2;
    public Transform player;


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

        float dx = Input.GetAxis(InputAxes.HorizontalMovement);
        float dy = Input.GetAxis(InputAxes.VerticalMovement);

        Vector3 velocity = new Vector3(dx, dy, 0) * playerSpeed;
        transform.Translate(velocity * Time.deltaTime);


    }



}
