using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class HomerMover : MonoBehaviour
{
    public float speed;
    private CharacterController characterController;
    private float z;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        z = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(0, 0, z * speed * Time.deltaTime));
        GetComponentInChildren<Animator>().SetFloat("Vertical", z);
    }
}
