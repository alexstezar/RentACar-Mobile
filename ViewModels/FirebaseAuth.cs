namespace RentACar_Mobile_.ViewModels
{
    internal class FirebaseAuth
    {
        private string webApiKey;

        public FirebaseAuth(string webApiKey)
        {
            this.webApiKey = webApiKey;
        }

        internal Task CreateUserWithEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}