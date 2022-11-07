using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Color lerpedColor;
    private Material cubeMat;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * Random.Range(1.3f, 3f);
        
        cubeMat = Renderer.material;

        cubeMat.color = new Color(0f, 1.0f, 0f, 0.95f);
    }
    
    void Update()
    {

        cubeMat.color = lerpedColor;
        lerpedColor = Color.Lerp(Color.cyan, Color.red, Mathf.PingPong(Time.time, 1));

        Scaling();

        Rotaty();
    }

    void Scaling()
    {
        if (Input.GetKey(KeyCode.W) && transform.localScale.x < 4f)
        {
            transform.localScale += 1.1f * Time.deltaTime * Vector3.one;
        }

        if (Input.GetKey(KeyCode.S) && transform.localScale.x > 0.4f)
        {
            transform.localScale -= 1.1f * Time.deltaTime * Vector3.one;
        }
    }

    void Rotaty()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(20f * -1f * Time.deltaTime, 20f * -1f * Time.deltaTime, 20f * -1f * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(20f * Time.deltaTime, 20f * Time.deltaTime, 20f * Time.deltaTime);
        }

        else
        {
            transform.Rotate(10.0f * Time.deltaTime, 10.00f * Time.deltaTime, 0.0f);
        }
    }

}
