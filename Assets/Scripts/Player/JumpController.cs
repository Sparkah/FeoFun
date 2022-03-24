using System;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    private float jumpForce;
    [SerializeField] float maxJumpForce = 420;
    [SerializeField] float speedGainRate = 420;
    private bool ignoreFirstTouch = true;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.touchCount > 0)
            {
                if (ignoreFirstTouch == false)
                {
                    if (jumpForce < maxJumpForce / 2)
                        jumpForce = maxJumpForce / 2;

                    jumpForce += Time.deltaTime * speedGainRate;
                    if (jumpForce > maxJumpForce)
                        jumpForce = maxJumpForce;
                }
            }
            else
            {
                ignoreFirstTouch = false;
                if (jumpForce > 0)
                {
                    Jump();
                }
            }
        }
    }

    private void Jump()
    {
        if (GetComponentsInChildren<Rigidbody>().Length > 0)
        {
            Rigidbody[] blocks = GetComponentsInChildren<Rigidbody>();
            foreach(Rigidbody block in blocks)
                block.AddForce(Vector3.up * jumpForce);
        }

        jumpForce = 0;
    }
}
