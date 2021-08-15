using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float upPositionLength = 0.4f;

    

    // Start is called before the first frame update
    void Start()
    {        
        MoveUp().SetLoops(-1, LoopType.Yoyo);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    private Tween MoveUp()
    {
        return transform.DOMoveY(transform.position.y + upPositionLength, 1).OnComplete(() => transform.DOScale(1.5f, 1));
    }
}
