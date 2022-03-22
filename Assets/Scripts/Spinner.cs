using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Spinning wall speed
    [SerializeField] float xSpeed = 0f; 
    [SerializeField] float ySpeed = 100f; 
    [SerializeField] float zSpeed = 0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Wall Spinner
        float xAxisSpin = Time.deltaTime * xSpeed;
        float yAxisSpin = Time.deltaTime * ySpeed;
        float zAxisSpin = Time.deltaTime * zSpeed;
        transform.Rotate(xAxisSpin, yAxisSpin, zAxisSpin);

    }
}
