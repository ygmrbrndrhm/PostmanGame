using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningAround : MonoBehaviour
{

    [SerializeField] float StreetSpeed = 200f;
    [SerializeField] float MoveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    float Speed;
    void Start()
    {
        Speed = MoveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Speed = boostSpeed;
            Debug.Log(Speed);
        }
   
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Speed = slowSpeed;
        Debug.Log(Speed);
    }
    void Update()
    {
        float StreetAmount = Input.GetAxis("Horizontal") * StreetSpeed * Time.deltaTime;
        float MoveSpeedAmount = Input.GetAxis("Vertical")* Speed * Time.deltaTime;
        transform.Rotate(0,0, -StreetAmount);
        transform.Translate(0, MoveSpeedAmount, 0);
    }
}
