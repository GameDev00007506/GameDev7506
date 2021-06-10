using System;
using DG.Tweening;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private float _animationDuration;
    [SerializeField] private Ease _easeType;
    [SerializeField] private float _endValue;
    private void Start()
    {
        this.gameObject.transform.DOMoveY(_endValue,_animationDuration).SetEase(_easeType).SetLoops(-1, LoopType.Yoyo);
    }
}
 