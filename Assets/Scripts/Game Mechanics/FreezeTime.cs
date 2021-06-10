using System;
using UnityEngine;

public class FreezeTime : MonoBehaviour
{
  private void Start()
  {
    IsTimeScale(1);
  }

  public void IsTimeScale(int timeScale)
  {
    Time.timeScale = timeScale;
  }
}
