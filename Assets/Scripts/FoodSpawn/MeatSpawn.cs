using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatSpawn : MonoBehaviour
{
    private List<int> meatList;
    [SerializeField] GameObject wholeHam;
    [SerializeField] GameObject mysteryMeat;
    [SerializeField] GameObject fishBone;
    [SerializeField] GameObject cookedFish;
    [SerializeField] GameObject cookedMeat;
    private GameObject newFood;


    // Start is called before the first frame update
    void Start()
    {
        meatList = new List<int> { 0, 1, 2, 3, 4};
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        int randomNum = Random.Range(0, meatList.Count);
        int randomMeat = meatList[randomNum];

        switch (randomMeat)
        {
            case 0:
                newFood = Instantiate(wholeHam, new Vector3(7, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 1:
                newFood = Instantiate(mysteryMeat, new Vector3(7, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 2:
                newFood = Instantiate(fishBone, new Vector3(7, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 3:
                newFood = Instantiate(cookedFish, new Vector3(7, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 4:
                newFood = Instantiate(cookedMeat, new Vector3(7, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            default: break;
        }

    }
}
