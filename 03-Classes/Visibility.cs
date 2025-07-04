using System.Runtime.CompilerServices;

partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new()
        {
            PowerLevel = 5000,
            LightSaberColor = "blue"
        };

        // jedi.UseForce();
        // WriteLine(jedi.PublicField);
        // WriteLine(jedi.PrivateField);
        // WriteLine(jedi.ProtectedField);
        jedi.RevealSecrets();

        Sith sith = new()
        {
            PowerLevel = 4000,
            LightSaberColor = "red"
        };
        sith.UseForce();
        // sith.ShowProtected();
    
    }

    interface IForceUser
    {
        int PowerLevel { get; set; }
        string? LightSaberColor { get; set; }

        void UseForce();
    }

    class Jedi : IForceUser
    {
        public string PublicField = "I am a Jedi y my power is known";
        private string PrivateField = "My deepest thoughts are private";
        protected string ProtectedField = " The dark side must not know my secrets";

        public int PowerLevel { get; set; }
        public string? LightSaberColor { get; set; }

        public void UseForce()
        {
            WriteLine($"I am a Jedi with a lightsabre {LightSaberColor} and my power level is {PowerLevel}");

        }

        private void Meditate()
        {
            WriteLine("I am in a deep meditation state with the force");
        }

        protected void Train()
        {
            WriteLine("I am training to be one with the force.");
        }

        public void RevealSecrets()
        {
            WriteLine(ProtectedField);
            WriteLine(PrivateField);
            Meditate();
        }
    }

    class Sith : Jedi, IForceUser
    {
        public new void UseForce()
        {
            WriteLine($"I ama a Sith with a lightsaber {LightSaberColor} and my power level is {PowerLevel}");
        }

        public void ShowProtected()
        {
            WriteLine(ProtectedField);
            Train();
        }
    }
}
