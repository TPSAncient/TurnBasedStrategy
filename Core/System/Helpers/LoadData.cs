namespace Core.System.Helpers
{
    public static class LoadData
    {
        public static T Load<T>(string fileName, string path)
        {
            return JsonData.LoadJson<T>(fileName, path);
        }
    }
}
