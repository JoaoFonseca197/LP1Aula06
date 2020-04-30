namespace MyGame
{
    class Enemy
    {
        private static int numPowerups;
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }


        public string GetName() => name;
            
        public string SetName(string name) 
        {
            this.name = name.Trim();
            return name;
        }

        public float GetHealth() => health;

        public float GetShield() => shield;


        public void TakeDamage(float demage)
        {
            shield -= demage;
            if(shield < 0)
            {
                float demageLeft = -shield;
                shield = 0;
                health -= demageLeft;
                if(health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            numPowerups++;
            if(powerUp == PowerUp.Health)
            {
                health+= gain;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += gain;
                if(shield > 100) shield = 100;
            }
        }

        public static int GetPowerupCount()
        {
            return numPowerups;
        }

        static Enemy()
        {
            numPowerups = 0;
        }
        
    }
}