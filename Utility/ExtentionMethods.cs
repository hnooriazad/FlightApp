namespace FlightApp.Utility
{
    public static class ExtentionMethods
    {
        public static string CreateQueryStringFromObject(this object obj)
        {
            string result = "";
            var props = obj.GetType().GetProperties();
            var accKey = props.Where(a => a.Name == "access_key").FirstOrDefault();
            if (accKey != null)
            {
                result += $"?{accKey.Name}={accKey.GetValue(obj)}";
            }
            foreach (var prop in props)
            {
                if (prop.Name == "access_key")
                {
                    continue;
                }
                else if (prop.GetValue(obj) != null && prop.GetValue(obj).ToString() != "")
                {
                    result += $"&{prop.Name}={prop.GetValue(obj)}";
                }
            }
            return result;
        }
    }
}
