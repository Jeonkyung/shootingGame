using UnityEngine;

public class missilemove : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    //�̻��� �߻� ������ ����
    //01�ð� �Ἥ �Ͻø� �ǿ�. 0.5�� ���� �� �߾� �������� ����
    //02 �̻��� �߻� ���� 5���� ���� 5�� �� ����� �����ð� ���弼��
    // ���� �ð��� 3�� �ּ��� 3�� �ڿ� 5�� ����
    public float timeCheck = 0.0f; //�ð� �� ���� ����
    public float timDelay = 0.0f; //������ �� ���� ����
    public int missleCount = 0; //�̻��� ���� ���� ����
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime,Space.World);
    }
}
