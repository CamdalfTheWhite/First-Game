using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Movement Speed
    [SerializeField] float moveSpeed = (3.0f);

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    // Show game instructions
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Help Cubert get to the bottom right corner without hitting the walls!");
        Debug.Log("You can move Cubert with the arrow keys, or the WASD keys");
    }

    //
    void PlayerMovement()
    {
        // Player Movement Variables
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Player Movement Input
        transform.Translate(xValue,0,zValue);

    }
}
