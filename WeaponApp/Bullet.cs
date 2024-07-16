using WeaponApp.Enums;

namespace WeaponApp
{
    public class Bullet
    {
        private static int _idCounter;

        public int Id { get; private set; }
        public BulletType Type { get; set; }

        public Bullet(BulletType type)
        {
            Id = ++_idCounter;
            Type = type;
        }
    }
}
