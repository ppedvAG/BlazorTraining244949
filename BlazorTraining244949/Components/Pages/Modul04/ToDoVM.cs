namespace BlazorTraining244949.Components.Pages.Modul04
{
    public class ToDoVM
    {
        public ToDoModel ToDo;

        public ToDoVM(IHttpClientFactory _http)
        {
            using (var client=_http.CreateClient())
            {
              ToDo=  client.GetFromJsonAsync<ToDoModel>("https://dummyjson.com/todos?limit=300").Result;
            }
        }

    }
}
