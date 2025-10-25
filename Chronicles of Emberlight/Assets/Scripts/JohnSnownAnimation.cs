using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnSnownAnimation : MonoBehaviour
{
    private JohnSnown johnSnown;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        johnSnown = GetComponent<JohnSnown>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        OnMove();
        OnRun();
        OnRolling();
    }
    #region Movement
    void OnMove()
    {


        if (johnSnown.direction.sqrMagnitude > 0)
        {
            anim.SetInteger("Transition", 1);
        }
        else
        {
            anim.SetInteger("Transition", 0);
        }

        if (johnSnown.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (johnSnown.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }

    void OnRun()
    {
        if (johnSnown.isRunning)
        {
            anim.SetInteger("Transition", 2);
        }
    }
    void OnRolling()
    {
        if (johnSnown.isRolling)
        {
            anim.SetInteger("Transition", 3);
        }
    }
    #endregion
}
