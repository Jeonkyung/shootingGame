using Unity.VisualScripting;
using UnityEngine;

public class watermove : MonoBehaviour
{
    //public float moveSpeed = 0.0f;
    public float scrollSpeedY = 0.0f;
    public float scrollValue = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {/*
        transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);

        if(transform.position.z<=-194.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 194.0f);
        }
    }*/
        scrollSpeedY = scrollSpeedY - scrollValue;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0.0f, scrollSpeedY);
    }
}
