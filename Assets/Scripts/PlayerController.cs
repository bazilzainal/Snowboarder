using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueApplied = 1f;
    [SerializeField] SurfaceEffector2D slopeEffector;
    [SerializeField] bool canMove;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        canMove = true;
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            RotatePlayer();
            MovePlayer();
        }
        else
        {
            slopeEffector.enabled = false;
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RotatePlayer()
    {
        float horiInput = Input.GetAxis("Horizontal");
        rb2d.AddTorque(horiInput * -torqueApplied);

    }

    void MovePlayer()
    {
        bool verInput = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        // Some janky code here
        if (verInput)
        {
            slopeEffector.enabled = true;
        }
        else
        {
            slopeEffector.enabled = false;
        }
    }
}
