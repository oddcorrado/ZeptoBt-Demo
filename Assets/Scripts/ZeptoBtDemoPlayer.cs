using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeptoBtDemoPlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [SerializeField] float acceleration;
    [SerializeField] float maxSpeed = 5;
    void Update()
    {
        var deltaVel = new Vector2();
        if (Input.GetKey(KeyCode.Z))
            deltaVel.y = acceleration;
        if (Input.GetKey(KeyCode.S))
            deltaVel.y = -acceleration;
        if (Input.GetKey(KeyCode.D))
            deltaVel.x = acceleration;
        if (Input.GetKey(KeyCode.Q))
            deltaVel.x = -acceleration;

        var vel = body.velocity;
        if (deltaVel.magnitude > 0) vel = body.velocity + deltaVel;
        else vel *= 0.95f;

        body.velocity = Mathf.Min(vel.magnitude, maxSpeed) * vel.normalized;
    }
}
