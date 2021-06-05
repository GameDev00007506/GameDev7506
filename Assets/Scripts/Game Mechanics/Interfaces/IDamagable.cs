

public interface IDamagable
{
  int HealthAmount { get; set; }
  
  public void Damage(int damageAmount);
}
