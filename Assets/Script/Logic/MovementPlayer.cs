using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float forceMovement = 0.5f;

    private Vector2 playerPosition;


    private void Start() {


    }


    private void Update()
    {
            float movementX = Input.GetAxisRaw("Horizontal");
            float movementY = Input.GetAxisRaw("Vertical");

            playerPosition = transform.position;

            playerPosition = playerPosition + new Vector2(movementX, movementY) * forceMovement * Time.deltaTime;

            transform.position = playerPosition;

            StartCoroutine(MovementGravity());

            //Debug.Log("Eje x: " + transform.position.x + ", eje y: " + transform.position.y);

        

    }

    IEnumerator MovementGravity()
    {
        yield return new WaitForSeconds(5f);
    }


}
