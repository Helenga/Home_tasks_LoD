namespace EnglishTrainer.Domain
{
    internal class UserActionsHandler : IUserActionsHandler
    {

        public void SetAnswer(bool answer)
        {
            _answer = answer;
        }

        public bool GetAnswer()
        {
            return _answer;
        }

        private bool _answer;
    }
}
