using UnityEngine;

public class missilespawner : MonoBehaviour
{
    public GameObject playermissile;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(playermissile, transform.position, transform.rotation);
        }
    }
}
