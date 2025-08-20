using UnityEngine;
using UnityEngine.Rendering.Universal;

public class playermove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    public float moveRL = 0.0f;
    public float moveFB = 0.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        Keymove();
        Limitmove();
    }

    void Keymove()
    {
        moveRL = Input.GetAxis("Horizontal");
        moveFB = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * moveRL * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * moveFB * moveSpeed * Time.deltaTime);
    }

    void Limitmove() //화면 밖으로 못 나가게
    {


    }
}
