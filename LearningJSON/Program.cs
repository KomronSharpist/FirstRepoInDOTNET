using Newtonsoft.Json;

namespace LearningJSON;

class Program
{
    public static void Main(string[] args)
    {
        List<Student> studentsList = new List<Student>();
        List<workers> WorkerList = new List<workers>();
        for (int i = 0; i < 20; i++)
        {
            Student students = new Student()
            {
                name = FakeData.NameData.GetFirstName(),
                surname = FakeData.NameData.GetSurname(),
                age = FakeData.NumberData.GetNumber(),
                email = FakeData.NetworkData.GetEmail(),
                grade = FakeData.NumberData.GetNumber(),
            };
            studentsList.Add(students);
            workers worker = new workers()
            {
                name = FakeData.NameData.GetFirstName(),
                surname = FakeData.NameData.GetSurname(),
                age = FakeData.NumberData.GetNumber(),
                email = FakeData.NetworkData.GetEmail(),
                workLocation = FakeData.PlaceData.GetStreetName()
            };
            WorkerList.Add(worker);
            Writer(studentsList, WorkerList);
        };
    }
    public static async void Writer(List<Student> first, List<workers> second)
    {
        var converted = JsonConvert.SerializeObject(first, Formatting.Indented);
        var convertWorkers = JsonConvert.SerializeObject(second, Formatting.Indented);
        File.AppendAllText(@"D:\Projects\LearningJSON\user.json", convertWorkers);
        File.AppendAllText(@"D:\Projects\LearningJSON\user.json", converted);
    }
}