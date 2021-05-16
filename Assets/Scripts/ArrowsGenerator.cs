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
    [SerializeField] private GameObject winScreen;

    private List<GameObject> arrowList = new List<GameObject>();
    private GameObject lastArrow;
    private float arrowTimer;
    private bool arrowSeted;
    private float songLength;
    private bool isPaused;
    private bool isAww;
    
    
    void Start()
    {
        arrowTimer = Random.Range(minTime, maxTime);
        arrowSeted = false;

        int song_no = PlayerPrefs.GetInt("song_no");
        songLength = SoundManager.instance.PlaySong(song_no);
    }


    void Update()
    {
        if (songLength > 0)
        {
            songLength -= Time.deltaTime;
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
                    isAww = true;
                }
            }
        }
        else
        {
            winScreen.SetActive(true);
        }
    }

    public void SwipeAction(int direction)
    {
        if (!isPaused)
        {
            if (arrowSeted)
            {
                var dir = lastArrow.GetComponent<ArrowType>().direction;
                if (dir == ArrowDirection.UP && direction == 0)
                {
                    if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
                    {
                        // TODO add particle effect perfect play
                        views.AddViews(perfectViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
                    {
                        // TODO add particle effect good job play
                        views.AddViews(goodViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
                    {
                        // TODO add particle effect nice play
                        views.AddViews(niceViews);
                        isAww = false;
                    }
                    else
                    {
                        // TODO add particle effect ohh play
                        isAww = true;
                    }
                }
                else if (dir == ArrowDirection.DOWN && direction == 1)
                {
                    if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
                    {
                        // TODO add particle effect perfect play
                        views.AddViews(perfectViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
                    {
                        // TODO add particle effect good job play
                        views.AddViews(goodViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
                    {
                        // TODO add particle effect nice play
                        views.AddViews(niceViews);
                        isAww = false;
                    }
                    else
                    {
                        // TODO add particle effect ohh play
                        isAww = true;

                    }
                }
                else if (dir == ArrowDirection.LEFT && direction == 2)
                {
                    if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
                    {
                        // TODO add particle effect perfect play
                        views.AddViews(perfectViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
                    {
                        // TODO add particle effect good job play
                        views.AddViews(goodViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
                    {
                        // TODO add particle effect nice play
                        views.AddViews(niceViews);
                        isAww = false;
                    }
                    else
                    {
                        // TODO add particle effect ohh play
                        isAww = true;

                    }
                }
                else if (dir == ArrowDirection.RIGHT && direction == 3)
                {
                    if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < perfectDistance)
                    {
                        // TODO add particle effect perfect play
                        views.AddViews(perfectViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < goodDistance)
                    {
                        // TODO add particle effect good job play
                        views.AddViews(goodViews);
                        isAww = false;
                    }
                    else if (Mathf.Abs(lastArrow.transform.position.x - swipePos.transform.position.x) < niceViews)
                    {
                        // TODO add particle effect nice play
                        views.AddViews(niceViews);
                        isAww = false;
                    }
                    else
                    {
                        // TODO add particle effect ohh play
                        isAww = true;

                    }
                }
                else
                {
                    // TODO add particle effect ohh play
                    isAww = true;

                }

                Destroy(lastArrow);
                arrowSeted = false;
            }
        }
    }

    public void setPause(bool paused)
    {
        isPaused = paused;
    }

    public bool GetPaused()
    {
        return isPaused;
    }

    public bool GetAww()
    {
        return isAww;
    }
}
