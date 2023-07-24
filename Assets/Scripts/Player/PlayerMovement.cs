using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 PlayerInput;

    public bool IsMoving = false;
    public bool IsPlaying = false;

    [SerializeField] CharacterController controller;
    [SerializeField] private float PlayerSpeed = 3f;
    [SerializeField] private float PlayerRotation = 40f;

    public AudioSource AS;
    public AudioClip Idle;
    public AudioClip Move;
    public AudioClip Shoot;



    //Setup camera lerp

    private void OnMove(InputValue value)
    {
        PlayerInput = value.Get<Vector2>();
    }

    private void PlayerMovementSystem()
    {
        //Find a better way to do this
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            
            IsMoving = true;

            if (IsPlaying == false)
            {
                AS.PlayOneShot(Move);
                IsPlaying = true;
            }
        }
        else
        {
            IsMoving = false;
            IsPlaying = false;
            AS.Stop();
        }

        controller.Move(transform.forward * PlayerInput.y * PlayerSpeed * Time.deltaTime);

        if(IsMoving == false)
        {
            transform.Rotate(transform.up, PlayerRotation * PlayerInput.x * Time.deltaTime);

           //if(IsPlaying == false)
           //{
           //    AS.PlayOneShot(Idle);
           //    IsPlaying = true;
           //}
            
        }
        else
        {
            return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementSystem();
    }
}
