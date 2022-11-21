using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    float startingPosition;

    private void Start()
    {
        startingPosition = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (-startingPosition + player.position.z).ToString("0");


    }
}
