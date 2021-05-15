using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
    [SerializeField] private float perfectDistance;
    [SerializeField] private float goodDistance;
    [SerializeField] private float niceDistance;
    [SerializeField] private ViewsController views;
    [SerializeField] private int perfectViews;
    [SerializeField] private int goodViews;
    [SerializeField] private int niceViews;

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
                lastArrow = arrowList[0];
                arrowList.RemoveAt(0);
                arrowSeted = true;
            }
        }


        if (arrowSeted)
        {
            if (swipePos.transform.position.x - lastArrow.transform.position.x > niceDistance + 5f)
            {
                Destroy(lastArrow);
                arrowSeted = false;
            }
            Debug.Log("Last arrow: ");
            Debug.Log(lastArrow.transform.position.x);
            Debug.Log("Swipe Position: ");
            Debug.Log(swipePos.transform.position.x);
        }
    }

    public void SwipeAction(int direction)
    {
        var dir = lastArrow.GetComponent<ArrowType>().direction;
        if (dir == ArrowDirection.UP && direction == 0)
        {
            if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
            {
                // TODO add sound perfect
                // TODO add particle effect perfect play
                views.AddViews(perfectViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
            {
                // TODO add sound good job
                // TODO add particle effect good job play
                views.AddViews(goodViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
            {
                // TODO add sound nice
                // TODO add particle effect nice play
                views.AddViews(niceViews);
            }
            else
            {
                // TODO add sound ohh
                // TODO add particle effect ohh play
            }
        }
        else if (dir == ArrowDirection.DOWN && direction == 1)
        {
            if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
            {
                // TODO add sound perfect
                // TODO add particle effect perfect play
                views.AddViews(perfectViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
            {
                // TODO add sound good job
                // TODO add particle effect good job play
                views.AddViews(goodViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
            {
                // TODO add sound nice
                // TODO add particle effect nice play
                views.AddViews(niceViews);
            }
            else
            {
                // TODO add sound ohh
                // TODO add particle effect ohh play
            }
        }
        else if (dir == ArrowDirection.LEFT && direction == 2)
        {
            if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
            {
                // TODO add sound perfect
                // TODO add particle effect perfect play
                views.AddViews(perfectViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
            {
                // TODO add sound good job
                // TODO add particle effect good job play
                views.AddViews(goodViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
            {
                // TODO add sound nice
                // TODO add particle effect nice play
                views.AddViews(niceViews);
            }
            else
            {
                // TODO add sound ohh
                // TODO add particle effect ohh play
            }
        }
        else if (dir == ArrowDirection.RIGHT && direction == 3)
        {
            if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
            {
                // TODO add sound perfect
                // TODO add particle effect perfect play
                views.AddViews(perfectViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
            {
                // TODO add sound good job
                // TODO add particle effect good job play
                views.AddViews(goodViews);
            }
            else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
            {
                // TODO add sound nice
                // TODO add particle effect nice play
                views.AddViews(niceViews);
            }
            else
            {
                // TODO add sound ohh
                // TODO add particle effect ohh play
            }
        }
        else
        {
            // TODO add sound ohh
            // TODO add particle effect ohh play
        }
        Destroy(lastArrow);
        arrowSeted = false;
    }
}
