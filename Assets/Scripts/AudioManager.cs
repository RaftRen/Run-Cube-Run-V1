using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance; //instance - ������� "���������"
    private void Awake()
    {
        if (instance != null)      //���� ������ AudiManager(� ���������� ������ Audio) ��� ���� � �����, ��
        {
            Destroy(gameObject);   //���������� ������� ������, �� ���� ����������� � gameObject �������������
        }                          //������, ����������� �������� �������� ������� ������, �� ���� ������ Audio.
        else
        {                          //�����, ���� � ����� ��� Audio, �� ����������� ���������� instance ��                  
            instance = this;       //����������� ������ �� ������ Audio
            DontDestroyOnLoad(gameObject); //� �������� ����� DonDestroyOnLoad, ����� ������ �� ��� ���������
        }                                  //����� ���������� ������� ����� � �������� � ���������
    }
}
