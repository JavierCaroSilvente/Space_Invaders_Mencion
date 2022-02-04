using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedEnemy;
    State currentState = State.INIT;
    public enum State
    {
        INIT,
        RIGHT,
        LEFT
    }

    public State state;

    void Start()
    {
        state = State.INIT;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.INIT:
                transform.Translate(Vector3.right * Time.deltaTime * speedEnemy);
                ChangeState(State.INIT);
                break;
            case State.RIGHT:
                transform.Translate(Vector3.right * Time.deltaTime * speedEnemy);
                ChangeState(State.RIGHT);
                break;
            case State.LEFT:
                transform.Translate(Vector3.left * Time.deltaTime * speedEnemy);
                ChangeState(State.LEFT);
                break;
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
    public void ChangeState(State state)
    {
        if(state != currentState)
        {
            speedEnemy += 0.5f;
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.75f);
            currentState = state;
        }
    }
}