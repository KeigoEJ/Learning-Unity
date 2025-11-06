using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveSpeed = 10f;

    void Start()
    {
        PrintInstruction();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Yooo!");
        Debug.Log("This is my early game");
        Debug.Log("Soo the game is easy, just dont bump!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }

}
