using UnityEngine;
using UnityEngine.UI;

public class ConsoleWriter : MonoBehaviour
{
    [SerializeField]
    private Cookie _cookie;

    private Text _text;
    void Awake()
    {
        _cookie.OnScoreChange += CookieOnOnScoreChange;
        _text = GetComponent<Text>();
    }

    private void CookieOnOnScoreChange(int score)
    {
        if(score % 10 == 0)
        {
            Debug.Log($"score is {score}");
        }
    }
}