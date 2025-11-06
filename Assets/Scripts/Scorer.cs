using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int scorePlayer = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            scorePlayer++;
            Debug.Log("You Bumped this many times: " + scorePlayer);
        }
        else
            Debug.Log("Nuh Uh!");
    }
}
