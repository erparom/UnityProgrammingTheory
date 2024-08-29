using UnityEngine;

public abstract class EnemyAbstract : MonoBehaviour, IPlayer
{
    protected string enemyName;

    string IPlayer.Name 
    { 
        get {
            return enemyName;
        } set {
            enemyName = value;
        }
    }
    
    Color IPlayer.Color { get; set; }
    
    int IPlayer.Hp { get; set; }
    
    int IPlayer.Speed { get; set; }
    
    int IPlayer.Strength { get; set; }
    
    bool IPlayer.IsAlive { get; set; }

    private bool _damageTaken = false;

    private bool _playerHit = false;

    void IPlayer.Hit(int Strength)
    {
        _playerHit = true;
        HitBehaviour(Strength);
    }

    void IPlayer.TakeDamage(int Damage)
    {
        _damageTaken = true;
        TakeDamageBehaviour(Damage);

    }

    protected abstract void TakeDamageBehaviour(int damage);

    protected abstract void HitBehaviour(int strengh)
}
