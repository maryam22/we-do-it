namespace api.Services
{
    internal class BonjourService : IBonjourService
    {
        public BonjourService()
        {
        }

        public string Bonjour()
        {
            return ("Hello from the BonjourService!");
        }
    }
}