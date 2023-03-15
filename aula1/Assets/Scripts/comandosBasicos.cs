using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class comandosBasicos : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    public float speed;
    private Vector2 move;
    private Vector3 moveDirection;
    private float direcaoMovimento;

    public bool isAnim;

    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        moveDirection = new Vector3(move.x, 0f, move.y);

        controller.Move(moveDirection * speed * Time.deltaTime);
    }
    public void Mover(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();

        isAnim = false;

        if (moveDirection.magnitude > 0)
        {
            direcaoMovimento = Mathf.Atan2(move.x, move.y) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0, direcaoMovimento, 0);

            isAnim = true;
        }

        anim.SetBool("Run", isAnim);
    }
}
