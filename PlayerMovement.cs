using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Speed = 10;

    private Vector3 up = new Vector3 (0, 0, 1);
    private Vector3 down = new Vector3 (0, 0, -1);
    private Vector3 left = new Vector3 (-1, 0, 0);
    private Vector3 right = new Vector3 (1, 0, 0);

    void Update()
    {
        if (Input.GetButton("Up"))
            transform.Translate(up * Speed * Time.deltaTime);

        if (Input.GetButton("Down"))
            transform.Translate(down * Speed * Time.deltaTime);

        if (Input.GetButton("Left"))
            transform.Translate(left * Speed * Time.deltaTime);

        if (Input.GetButton("Right"))
            transform.Translate(right * Speed * Time.deltaTime);
    }
}