using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestrtoyer : MonoBehaviour
{
    private GameObject blocks;

    private void OnCollisionEnter2D(Collider2D block)
    {
        int chldcnt = this.transform.childCount;
        for(int i = 0; i < chldcnt; i++)
        {
            if(block.gameObject.name == "ball")
            {
                Destroy(this);
            }
            // .transform.childCount
        }
    }
}
