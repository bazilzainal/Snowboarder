using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueApplied = 1f;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float horiInput = Input.GetAxis("Horizontal");
        rb2d.AddTorque(horiInput * -torqueApplied);

        if (horiInput != 0)
        {
            Debug.Log("Torque applied! " + horiInput + " torque units.");
        }

    }
}
