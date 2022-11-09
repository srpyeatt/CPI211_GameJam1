using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegetableSpawn : MonoBehaviour
{
    private List<int> vegetableList;
    [SerializeField] GameObject broccoli;
    [SerializeField] GameObject carrot;
    [SerializeField] GameObject corn;
    [SerializeField] GameObject apple;
    [SerializeField] GameObject banana;
    [SerializeField] GameObject coconut;
    [SerializeField] GameObject pear;
    [SerializeField] GameObject cookedbroccoli;
    [SerializeField] GameObject cookedcarrot;
    [SerializeField] GameObject cookedcorn;
    private GameObject newFood;


    // Start is called before the first frame update
    void Start()
    {
        vegetableList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        int randomNum = Random.Range(0, vegetableList.Count);
        int randomVegetable = vegetableList[randomNum];

        switch (randomVegetable)
        {
            case 0:
                newFood = Instantiate(broccoli, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 1:
                newFood = Instantiate(carrot, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 2:
                newFood = Instantiate(corn, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 3:
                newFood = Instantiate(apple, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 4:
                newFood = Instantiate(banana, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 5:
                newFood = Instantiate(coconut, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 6:
                newFood = Instantiate(pear, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 7:
                newFood = Instantiate(cookedbroccoli, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 8:
                newFood = Instantiate(cookedcarrot, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            case 9:
                newFood = Instantiate(cookedcorn, new Vector3(5, 2, 8), Quaternion.identity);
                newFood.name = newFood.name.Replace("(Clone)", "");
                break;
            default: break;
        }

    }
}
