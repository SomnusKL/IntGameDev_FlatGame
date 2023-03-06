using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    //speed
    public float moveSpeed = 5;

    private Vector3 _position;
    private Vector3 _boarderScale;
    private Collider2D _cameraBox;
    private (float x, float y) _cameraSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * (-moveSpeed * Time.deltaTime);

        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * (moveSpeed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * (-moveSpeed * Time.deltaTime);

        }

              

    }
}
