using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDropper : MonoBehaviour
{
    // Time to drop obstacle
    [SerializeField] float SecondsSinceStart = (3.0f);
    // Cache MeshRenderer state
    MeshRenderer renderer;
    // Cache gravity enabled
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent <MeshRenderer>();
        rigidbody = GetComponent <Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Drop obstacle after time passes
        if ( Time.time > SecondsSinceStart ) 
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
