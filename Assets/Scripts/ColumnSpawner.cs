using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    
    public GameObject column;

    public float maxTime;
    float timer;

    public float maxY;
    public float minY;
    float randY;


    // Start is called before the first frame update
    void Start()
    {
        //InstantiateColumn();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver == false && GameManager.gameHasStarted == true)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                InstantiateColumn();
                timer = 0;
            }
        }
        
    }

    public void InstantiateColumn()
    {
        randY = Random.Range(minY, maxY);
        GameObject newColumn = Instantiate(column);
        newColumn.transform.position = new Vector2(
            transform.position.x,
            randY);
    }

}
