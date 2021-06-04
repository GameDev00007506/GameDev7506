using System;
using DG.Tweening;
using UnityEngine;
public class MovePlatform : MonoBehaviour
{
   [SerializeField] private Vector2 _finalPosition;

   [SerializeField] private Ease _easeType;

   private Vector2 _originalPosition, _currentPosition;

   [SerializeField] private float _duration = 4f;
   
   [SerializeField] private float _delay = 0.5f;

   private void Start()
   {
      _originalPosition = transform.position;
      _currentPosition = _finalPosition;
      Move(_currentPosition);
   }

   private void Move(Vector2 pos)
   {
      transform.DOMove(pos, _duration).SetEase(_easeType).OnComplete(() => Move(_currentPosition)).SetDelay(_delay);
      _currentPosition = _currentPosition == _finalPosition ? _originalPosition : _finalPosition;
   }
}
