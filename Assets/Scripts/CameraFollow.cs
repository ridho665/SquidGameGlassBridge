using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTarget;

    public Vector3 offset;

    public float cameraSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate() 
    {
        transform.position = Vector3.Lerp(transform.position, playerTarget.position + offset, cameraSpeed * Time.deltaTime);       
    }
}
