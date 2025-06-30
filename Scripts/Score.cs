using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private TextMeshProUGUI Score_;

    private void Update()
    {   //�������� text ������ Text, � ������ ������ ���������� Score_ ��������� ��������� �������� ��� Score_
        Score_.text = Player.position.z.ToString("0"); //0 ������ ���� ������ ����� �������
    }
}
