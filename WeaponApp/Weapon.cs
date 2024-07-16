using System;
using System.Collections.Generic;
using WeaponApp.Enums;

namespace WeaponApp
{
    public class Weapon
    {
        private static int _idCounter = 0;
        private List<Bullet> _ammo;

        public int Id { get; private set; }
        public BulletType AmmoType { get; private set; }
        public int Capacity { get; private set; }

        public Weapon(BulletType ammoType, int capacity)
        {
            Id = ++_idCounter;
            AmmoType = ammoType;
            Capacity = capacity;
            _ammo = new List<Bullet>(capacity);
        }

        public void Fire()
        {
            if (_ammo.Count > 0)
            {
                Bullet bullet = _ammo[0];
                _ammo.RemoveAt(0);
                Console.WriteLine($"Fired a {bullet.Type} bullet. {_ammo.Count} bullets left.");
            }
            else
            {
                Console.WriteLine("No bullets left to fire!");

            }
        }

        public void Fill()
        {
            for (int i = _ammo.Count; i < Capacity; i++)
            {
                _ammo.Add(new Bullet(AmmoType));
            }
            Console.WriteLine($"Weapon filled with {AmmoType} bullets. Current ammo count: {_ammo.Count}");
        }

        public void PullTrigger()
        {
            if (_ammo.Count > 0)
            {
                Bullet bullet = _ammo[0];
                Console.WriteLine($"Next bullet type: {bullet.Type}");
                 ;
            }
            else
            {
                Console.WriteLine("No bullets left!");
            }
        }
    }
}
