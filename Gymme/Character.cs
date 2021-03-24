namespace Gymme
{
    public sealed class Character
    {
        private static Character instance = null;
        private static readonly object padlock = new object();

        private string characterName = "";

        public Character()
        {

        }

        public override string ToString()
        {
            return CharacterName;
        }
        public static Character Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Character();
                    }
                    return instance;
                }
            }
        }

        public string CharacterName { get => characterName; set => characterName = value; }
    }
}

