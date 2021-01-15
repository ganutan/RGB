using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class BtnPress : MonoBehaviour
{
    
    public GameObject cube;
    
    public Material cubeMat, wallpaperMat;
    static float r, g, b;
    string rdisplay, gdisplay, bdisplay;
    public Text rtext, btext, gtext;

    private void Start()
    {
        cube.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
    }

    public void OnRedPpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.r >= 1)
            return;
        else
        {
            r += 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

    public void OnGreenPpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.g >= 1)
            return;
        else
        {
            g += 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

    public void OnBluePpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.b >= 1)
            return;
        else
        {
            b += 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

    public void OnRedMpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.r <= 0)
            return;
        else
        {
            r -= 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

    public void OnGreenMpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.g <= 0)
            return;
        else
        {
            g -= 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

    public void OnBlueMpressed()
    {
        if (cube.GetComponent<MeshRenderer>().material.color.b <= 0)
            return;
        else
        {
            b -= 0.1f;
            cube.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
        }
    }

  



    void Update()
    {
        r = cube.GetComponent<MeshRenderer>().material.color.r;
        g = cube.GetComponent<MeshRenderer>().material.color.g;
        b = cube.GetComponent<MeshRenderer>().material.color.b;

        

        if (r <= 0)
            rtext.text = ("0");
        else if (r >= 255)
            rtext.text = ("255");
        else
        {
            rdisplay = Convert.ToString(r * 255);
            rtext.text = rdisplay;
        }


        if (g <= 0)
            gtext.text = ("0");
        else if (g >= 255)
            gtext.text = ("255");
        else
        {
            gdisplay = Convert.ToString(g * 255);
            gtext.text = gdisplay;
        }


        if (b <= 0)
            btext.text = ("0");
        else if (b >= 255)
            btext.text = ("255");
        else 
        {
            bdisplay = Convert.ToString(b * 255);
            btext.text = bdisplay;
        }

        cubeMat.color = cube.GetComponent<MeshRenderer>().material.color;
        wallpaperMat.color = cube.GetComponent<MeshRenderer>().material.color;
        
    }
}
