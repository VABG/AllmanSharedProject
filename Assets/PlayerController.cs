using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) moveInput += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) moveInput += Vector3.back;
        if (Input.GetKey(KeyCode.A)) moveInput += Vector3.left;
        if (Input.GetKey(KeyCode.D)) moveInput += Vector3.right;
        moveInput.Normalize();
        transform.position += moveInput * moveSpeed * Time.deltaTime;

    }
}
