using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFood : MonoBehaviour
{
    // private int numberOfFood = 0;

    public int score;

    List<GameObject> food = new List<GameObject>();

    public void Serve()
    {
        if (food.Count == 3)
        {
            score++;
        }

        Debug.Log("Start: " + food.Count);

        foreach (GameObject go in food)
        {
            Destroy(go);
        }

        food.Clear();

        gameObject.GetComponent<ScoreText>().ChangeText(score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FoodObject")
        {
            food.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "FoodObject")
        {
            food.Remove(other.gameObject);
        }
    }
}
