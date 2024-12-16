using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeFood : MonoBehaviour
{
    // private int numberOfFood = 0;

    [SerializeField] AudioSource source;
    [SerializeField] AudioClip clip;

    public int score;

    List<GameObject> food = new List<GameObject>();

    public void Serve()
    {
        if (food.Count == 3)
        {
            source.PlayOneShot(clip);
            score++;
        }

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
