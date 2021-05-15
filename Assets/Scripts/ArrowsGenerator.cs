using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsGenerator : MonoBehaviour
{
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] private GameObject upArrow;
    [SerializeField] private GameObject downArrow;
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;
    [SerializeField] private GameObject swipePos;

    private List<GameObject> arrowList = new List<GameObject>();
    private GameObject lastArrow;
    private float arrowTimer;
    private bool arrowSeted;
    
    
    void Start()
    {
        arrowTimer = Random.Range(minTime, maxTime);
        arrowSeted = false;
    }


    void Update()
    {
        if (arrowTimer <= 0f)
        {
            var arrow = Random.Range(0, 3);
            switch (arrow)
            {
                case 3:
                {
                    GameObject toAdd = Instantiate(rightArrow, this.transform);
                    arrowList.Add(toAdd);
                    break;
                }
                case 2:
                {
                    GameObject toAdd = Instantiate(leftArrow, this.transform);
                    arrowList.Add(toAdd);
                    break;
                }
                case 1:
                {
                    GameObject toAdd = Instantiate(downArrow, this.transform);
                    arrowList.Add(toAdd);
                    break;
                }
                case 0:
                {
                    GameObject toAdd = Instantiate(upArrow, this.transform);
                    arrowList.Add(toAdd);
                    break;
                }
            }
            arrowTimer = Random.Range(minTime, maxTime);
        }
        else
        {
            arrowTimer -= Time.deltaTime;
        }

        if (!arrowSeted)
        {
            if (arrowList.Count != 0)
            {
                lastArrow = arrowList[arrowList.Count - 1];
                arrowSeted = true;
            }
        }
    }

    public void SwipeAction(int direction)
    {
        var dir = lastArrow.GetComponent<ArrowType>().direction;
        if (dir == ArrowDirection.UP && direction == 0)
        {
            
        }
        else if (dir == ArrowDirection.DOWN && direction == 1)
        {
            
        }
        else if (dir == ArrowDirection.LEFT && direction == 2)
        {
            
        }
        else if (dir == ArrowDirection.RIGHT && direction == 3)
        {
            
        }
        else
        {
            
        }
    }
}
