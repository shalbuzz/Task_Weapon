using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Weapon: Isingle, IAutomatic
    {
        private int _bulletCapacity;
        public int BulletCapacity { get => _bulletCapacity; set {

                if (BulletCapacity < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _bulletCapacity = value;
                }
            } }

        private int _bulletCount;
        public int BulletCount { get => _bulletCount; set { 
            if(BulletCount < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _bulletCount = value;
                }
            } }

        public FireMode FireMode { get; private set; }

        
        public Weapon(int bulletCapacity, int bulletCount, FireMode firemode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            FireMode = firemode;

        }

        public void Shoot()

        {

            if (BulletCount > 0)
            {
                if (FireMode == FireMode.Single) { BulletCount -= 1; }

                else if(FireMode == FireMode.Automatic)
                {
                    BulletCount = 0;
                }

                else if(FireMode == FireMode.Burset)
                {
                    BulletCount -= 3;
                }
              
            }
           
        }

        public void Fire()
        {
            BulletCapacity = 0;
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity - BulletCount;
        }
        
        public void Reload()
        {
            BulletCount = BulletCapacity;
        }
       
        public FireMode ChangeFireMode(string value)
        {
            if (FireMode == FireMode.Single) {
            
                FireMode = FireMode.Single;
            
            }
            else if(FireMode == FireMode.Automatic)
            {
                FireMode = FireMode.Automatic;
            }
            else if( FireMode == FireMode.Burset)
            {
                FireMode = FireMode.Burset;
            }
           return FireMode;

        }

    }
}
