using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text displayText;
    void Update()
    {
        displayText.text = Player.InstPlayer.Score.ToString();
    }

}
