using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        if (player == null)
            player = GameObject.Find("Player");
    }

    void Update()
    {
        int score = (int)player.transform.position.z;
        scoreText.text = score.ToString();
    }

}
