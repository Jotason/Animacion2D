using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{
    // Start is called before the first frame update

    //public Transform puerta;
    Animator animator;
    public bool abrirbol;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void abrir()
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(90,0,60));
        animator.SetBool("Abierto", false);
        abrirbol = true;
        Debug.Log("abrido");

    }

    public void cerrar()
    {
        transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
        animator.SetBool("Abierto", true);
        abrirbol = false;
        Debug.Log("Cerrado");
    }
}
