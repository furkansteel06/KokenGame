using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Piece : MonoBehaviour, IPointerClickHandler
{
    public GameObject puzzleManager;

    private void Start()
    {
        puzzleManager = GameObject.Find("PuzzleManager");
    }
        

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject click = this.gameObject;
        Debug.Log(click.name);
        puzzleManager.GetComponent<PuzzleControl>().PieceShow(click); 


    }

}