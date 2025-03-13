namespace BlazorTraining244949.Components.Pages.Modul04
{
    public class ToDoModel
    {
   
        public Todo[] todos { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }

    public class Todo
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool completed { get; set; }
        public int userId { get; set; }
    }

}
