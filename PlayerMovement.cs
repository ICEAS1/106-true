using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12f;
    CharacterController character;
    
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        character.Move(transform.forward * vertical * speed * Time.deltaTime);
        character.Move(transform.right * horizontal * speed * Time.deltaTime);
    }
}
