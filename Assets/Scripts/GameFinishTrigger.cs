using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishTrigger : MonoBehaviour
{
    [SerializeField] private EndPoint[] _points;
    

    private void OnEnable()
    {
        //  _points = GameObject.FindObjectsOfType<EndPoint>();

        _points = gameObject.GetComponentsInChildren<EndPoint>();

        foreach (var point in _points)
        {
            point.Reached += OnEndPointReached;
        }
    }

    private void OnDisable()
    {
        foreach (var point in _points)
        {
            point.Reached -= OnEndPointReached;
        }
    }

    private void OnEndPointReached()
    {
        foreach (var point in _points)
        {
            if (point.IsReached == false)
            {
                return;
            }
        }


        Debug.Log("Finish");
    }
}
