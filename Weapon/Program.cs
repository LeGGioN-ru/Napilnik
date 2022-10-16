using System;

namespace Weapon
{
    class Weapon
    {
        private int _damage;
        private int _bullets;

        public void Fire(Player player)
        {
            if (_bullets <= 0)
                throw new ArgumentException(nameof(_bullets));

            if (_damage < 0)
                throw new ArgumentException(nameof(_damage));

            player.TakeDamage(_damage);
            _bullets -= 1;
        }
    }

    class Player
    {
        private int _health;

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health < 0)
                _health = 0;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
