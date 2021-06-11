using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour, IDamagable
{ 
    
    [SerializeField] private PlayerDeath _playerDeath;
  [SerializeField] private Slider _slider;
  public int HealthAmount { get; set; }

  private void Awake()
  {
      HeallingPowerUp.OnObjectCollided += UpdateSlider;
      HazardEnemy.OnObjectDamaged += UpdateSlider;
  }

  private void Start()
  {
      HealthAmount = Mathf.Clamp(HealthAmount, 0, 100);
      HealthAmount = 50;
      UpdateSlider();
  }

  public void Damage(int damageAmount)
  {
      if (HealthAmount > 1)
      {
          HealthAmount -= damageAmount;
          UpdateSlider();
      }
      else
      {
         _playerDeath.PlayerIsDead();
      }
     
  }

  public void UpdateSlider()
  {
      _slider.value = HealthAmount;
  }

  private void OnDestroy()
  {
      HeallingPowerUp.OnObjectCollided -= UpdateSlider;
      HazardEnemy.OnObjectDamaged -= UpdateSlider;
  }
}
