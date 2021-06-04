

public interface IDamagable
{
  int _healthAmount { get; set; }
  
  public void Damage(int damageAmount);
}
