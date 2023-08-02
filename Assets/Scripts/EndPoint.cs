using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{

   // [SerializeField] private SpriteRenderer _renderer;
   // [SerializeField] private Color _researchColor;
    [SerializeField] private UnityEvent _reached = new UnityEvent(); // new UnityEvent() - заглушка

    public event UnityAction Reached
    {
        add => _reached.AddListener(value);
        remove => _reached.RemoveListener(value);
    }

    public bool IsReached { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsReached)
        {
            return;
        }
        
        if (collision.TryGetComponent<Player>(out Player player))
        {
            // _renderer.color = _researchColor;

            IsReached = true;
            Debug.Log(gameObject.name);
            _reached.Invoke();


        }
    }
}
