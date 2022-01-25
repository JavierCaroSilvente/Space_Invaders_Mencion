using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speedEnemy;
    public enum State
    {
        RIGHT,
        LEFT
    }

    public State state;

    void Start()
    {
        state = State.RIGHT;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.RIGHT)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedEnemy);
        }

        if (state == State.LEFT)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speedEnemy);
        }

        if (transform.position.x <= -6.7f)
        {
            state = State.LEFT;
        }

        if (transform.position.x >= 6.7f)
        {
            state = State.RIGHT;
        }
    }
}