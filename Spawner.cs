using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemy;

    public GameObject[] spawnposision;
    
    public float TimerTimer;

    private float Timer;

    private int rand;

    private int randPosition;

    private void Start()
    {
        Timer = TimerTimer;
    }

    private void Update()
    {
        if (Timer <= 0)
        {
            rand = Random.Range(0, enemy.Length);

            randPosition = Random.Range(0, spawnposision.Length);

            Instantiate(enemy[rand], spawnposision[randPosition].transform.position, Quaternion.identity);

            Timer = TimerTimer;
        }
        else
        {
            Timer -= Time.deltaTime;
        }
    }
}

