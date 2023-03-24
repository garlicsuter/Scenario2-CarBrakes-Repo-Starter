using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tire : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager GM;
    public GameObject caliperAndPads;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        Debug.Log("Grav = " + rb.useGravity + ", Kin = " + rb.isKinematic);
    }

    public void EnableRBGravity()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        GM.score += 5;
        GM.UpdateScore();
        caliperAndPads.GetComponent<XRGrabInteractable>().enabled = true;

        Debug.Log("Tire Gravity...COMMENCE!");
    }
}
