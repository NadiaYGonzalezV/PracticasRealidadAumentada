using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totation : MonoBehaviour
{
   

    // Velocidad de rotación en grados por segundo
    public Vector3 rotationSpeed = new Vector3(0, 50, 0);

    // Update se llama una vez por frame
    void Update()
    {
        // Rota el objeto alrededor de sus ejes locales
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }

}
