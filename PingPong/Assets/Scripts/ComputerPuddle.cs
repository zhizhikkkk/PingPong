using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPuddle : Puddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if(this.ball.position.y>this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
            else if(this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if (this.ball.velocity.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
            else if (this.ball.velocity.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
