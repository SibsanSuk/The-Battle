using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    public GameObject canvas;
    public GameObject target;
    bool triggered = false;
    bool gateOpen = false;
    public Animator animator;

    void Update()
    {
        if (triggered && Input.GetKeyDown(KeyCode.E))
        {
            gateOpen = !gateOpen;
            animator.SetBool("Open", gateOpen);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        canvas.SetActive(true);
        triggered = true;
    }
    void OnTriggerExit(Collider collider)
    {
        canvas.SetActive(false);
        triggered = false;
    }
}
