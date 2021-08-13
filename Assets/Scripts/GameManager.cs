using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static int _leftScore = 0;
    private static int _rightScore = 0;

    public TextMeshProUGUI LeftScoreTxt;
    public TextMeshProUGUI RightScoreTxt;

    private GameObject _ball;

    // Start is called before the first frame update
    void Start ()
    {
        _ball = GameObject.FindGameObjectWithTag("Ball");
    }

    void UpdateScore (string side)
    {
        switch (side)
        {
            case "Right":
                _rightScore++;
                RightScoreTxt.text = _rightScore.ToString();
                break;

            case "Left":
                _leftScore++;
                LeftScoreTxt.text = _leftScore.ToString();
                break;

            default:
                Debug.Log("Side not found");
                break;
        }
    }
}
