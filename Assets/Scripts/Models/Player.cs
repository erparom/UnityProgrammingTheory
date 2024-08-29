using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    string IPlayer.Name { get; set; }
    
    Color IPlayer.Color { get; set; }
    
    int IPlayer.Hp { get; set; }
    
    int IPlayer.Speed { get; set; }
    
    int IPlayer.Strength { get; set; }
    
    bool IPlayer.IsAlive { get; set; }
    
    void IPlayer.TakeDamage(int Damage)
    {
        
        
    }
    
    void IPlayer.Hit(int Strength)
    {

    }
}
