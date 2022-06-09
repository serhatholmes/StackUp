using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    [SerializeField] private Transform reference;
    [SerializeField] private Transform falling;
    [SerializeField] private Transform stand;

    [SerializeField] private float TEST_VALUE;

    [ContextMenu("TEST")]
    private void TEST(){

        DivideObject(TEST_VALUE);
    }

    private void DivideObject(float value){
        //size
        var fallingSize = reference.localScale;
        fallingSize.x = value;
        falling.localScale = fallingSize;

        var standSize = reference.localScale;
        standSize.x = reference.localScale.x - value;
        stand.localScale = standSize;
    }

    /*private Vector3 GetPositionEdge(MeshRenderer mesh){
        var extents = mesh.bounds.extents;
        var position = mesh.transform.position;

        position.x = 

    }*/

}
