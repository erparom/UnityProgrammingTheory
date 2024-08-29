using UnityEngine;

interface IPlayer
{
    string Name { get; set; }
    Color Color { get; set; }
    int Hp  { get; set; }
    int Strength { get; set; }
    int Speed { get; set; }
    bool IsAlive  { get; set; }
    void TakeDamage(int Damage);
    void Hit(int Strength); 
}
