using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class WearAnimations : MonoBehaviour
{
    private Vector2 _movement;

    private Animator _animator;

    private const string _horizontal = "Horizontal";
    private const string _vertical = "Vertical";

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _movement.Set(InputManager.Movement.x, InputManager.Movement.y);

        _animator.SetFloat(_horizontal, _movement.x);
        _animator.SetFloat(_vertical, _movement.y);
    }
}
