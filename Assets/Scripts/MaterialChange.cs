using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public GameObject ARPlane, obj;
    public Material wallPaperMat;

    static float r, g, b;

    private void Update()
    {
        r = obj.GetComponent<Renderer>().material.color.r;
        g = obj.GetComponent<Renderer>().material.color.g;
        b = obj.GetComponent<Renderer>().material.color.b;

        ARPlane.GetComponent<Renderer>().material.color = new Color(r,g,b) ;
    }

}
