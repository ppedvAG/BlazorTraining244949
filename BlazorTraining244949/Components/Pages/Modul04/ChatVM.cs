namespace BlazorTraining244949.Components.Pages.Modul04
{
    public class ChatVM
    {
        public List<ChatModel> ChatList { get; set; } = new();
        public event Action OnAdd;
        public void AddMessage(string msg)
        {
            ChatList.Add(new ChatModel { Name = "User", Message = msg });
            OnAdd?.Invoke();
        }

    }
}
