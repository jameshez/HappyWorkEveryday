using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HappyWorkEveryday.Helper
{
    public static class TestDataGenerator
    {
        static Random rnd = new Random();

        /// <summary>
        /// How many fake data need to be generate
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        /// <returns></returns>
        public static ObservableCollection<T> Generate<T>(int n)
        {
            var returnCollection = new ObservableCollection<T>();

            Type classType = typeof(T);

            var list = classType.GetRuntimeProperties();

            object obj = Activator.CreateInstance(classType);

            foreach (PropertyInfo item in list)
            {
                if (item.PropertyType == typeof(string))
                {
                    if (item.Name.ToUpper().Contains("NAME"))
                    {
                        item.SetValue(obj, "FakeName");
                    }
                    else if (item.Name.ToUpper().Contains("TIME"))
                    {
                        item.SetValue(obj, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                    }
                    else if (item.Name.ToUpper().Contains("ALIAS"))
                    {
                        item.SetValue(obj, "v-fake");
                    }
                    else
                    {
                        item.SetValue(obj, "Whatever");
                    }

                }
                if (item.PropertyType == typeof(DateTime))
                {
                    item.SetValue(obj, DateTime.Now);
                }
                if (item.PropertyType == typeof(double))
                {
                    item.SetValue(obj, rnd.NextDouble()*100);
                }

            }
            for (int i = 0; i < n; i++)
            {
                returnCollection.Add((T)obj);
            }

            return returnCollection;
        }
    }
}
