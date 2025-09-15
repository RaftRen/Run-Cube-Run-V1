using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private TextMeshProUGUI Score_;

    private void Update()
    {   //свойство text класса Text, в данном случае экземпл€ра Score_ указывает текстовое значение дл€ Score_
        Score_.text = Player.position.z.ToString("0"); //0 значит ноль знаков после зап€той
    }
}
