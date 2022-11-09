using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private List<int> enemyList;
    [SerializeField] GameObject broccoli;
    [SerializeField] GameObject carrot;
    [SerializeField] GameObject corn;
    [SerializeField] GameObject fish;
    [SerializeField] GameObject meat;

    // Start is called before the first frame update
    void Start()
    {
        enemyList = new List<int> {0,1,2,3,4};
        InvokeRepeating("SpawnEnemy", 10.0f, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int randomNum = Random.Range(0, enemyList.Count);
        int randomEnemy = enemyList[randomNum];

        switch(randomEnemy) {
            case 0:
                Instantiate(broccoli, new Vector3(25, 2, 25), Quaternion.identity);
                break;
            case 1:
                Instantiate(carrot, new Vector3(25, 2, 25), Quaternion.identity);
                break;
            case 2:
                Instantiate(corn, new Vector3(25, 2, 25), Quaternion.identity);
                break;
            case 3:
                Instantiate(fish, new Vector3(25, 2, 25), Quaternion.identity);
                break;
            case 4:
                Instantiate(meat, new Vector3(25, 2, 25), Quaternion.identity);
                break;
            default: break;
        }

    }
}
