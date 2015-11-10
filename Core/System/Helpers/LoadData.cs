namespace Core.System.Helpers
{
    public static class LoadData
    {
        public static T Load<T>(string fileName)
        {
            return JsonData.LoadJson<T>(fileName);
        }
    }
}
