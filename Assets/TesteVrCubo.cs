using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteVrCubo : MonoBehaviour
{ bool Jogando = false;
    float spinForce = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Jogando == false) { 
        transform.Rotate(0, 4 * spinForce * Time.deltaTime, 9);
    } }
    public void Change()
    {
        Jogando = true;
        spinForce = -spinForce;
        print("deu ceto");
    }
    public void saiu()
    {
        Jogando = false;
    }
}
