﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena
{
     internal abstract class Character
    {
        private string _name = "Character";
        private float _maxHealth = 10;
        private float _health = 10;
        private float _attackPower = 1;
        private float _defensePower = 1;

        public string Name {  get { return _name; } }
        public float MaxHealth {  get { return _maxHealth; } }
        public float Health
        {
            get { return _health; }
            private set { _health = Math.Clamp(value, 0, _maxHealth); }
        }

        public float Fight(Character attacker, Enemy defender)
        {
            float damageTaken = CalculateDamage(attacker.AttackPower, defender.DefensePower);
            defender._health -= damageTaken;
            return damageTaken;
        }

        public abstract void Speak();
       
        public float Fight(Enemy attacker, Character defender)
        {
            float damageTaken = CalculateDamage(attacker.AttackPower, defender.DefensePower);
            defender._health -= damageTaken;
            return damageTaken;
        }


        float CalculateDamage(float attack, float defence)
        {
            float damage = attack - defence;
            // damage clamp method 1
            if (damage <= 0)
            {
                damage = 0;
            }

            return damage;

        }
        public float AttackPower { get { return _attackPower; } }
        public float DefensePower { get { return _defensePower; } }

        

        public Character(string name, float maxHealth, float attackPower, float defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
            
        }


        public float Attack(Character other)
        {
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public void TakeDamage(float damage)
        {
           

            Health -= damage;
            if (Health == 0) 
            {
               Die();
            }
        }


        public void Heal(float health)
        {
            Health += health;
        }
         public void Die()
         {
            Console.WriteLine(Name + " has died!");
         }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Health: " + Health + "/" + MaxHealth);
            Console.WriteLine("Attack Power: " + AttackPower);
            Console.WriteLine("Defense Power:" + DefensePower);
        }
        



    }
}
