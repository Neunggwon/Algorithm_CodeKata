using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public enum JobType
    {
        [StringValue("전사")]
        JT_Warrior,
        [StringValue("마법사")]
        JT_Mage,
        [StringValue("도적")]
        JT_Thief,
        [StringValue("궁수")]
        JT_Archer
    }

    public class StringValueAttribute : Attribute
    {
        public string Value { get; }

        public StringValueAttribute(string value)
        {
            Value = value;
        }
    }
    public class AAA : Attribute
    {

    }
    public static class EnumExtensions
    {
        public static string GetStringValue(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var stringValueAttribute = (StringValueAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(StringValueAttribute));
            return stringValueAttribute?.Value ?? value.ToString();
        }
    }

    class Test
    {
        static void Main()
        {
            List<JobType> jobList = new List<JobType> { JobType.JT_Warrior, JobType.JT_Mage, JobType.JT_Thief };

            foreach (var job in jobList)
            {
                string jobString = job.GetStringValue();
                Console.WriteLine($"Job: {jobString}");
            }
        }
    }
    //internal class Test
    //{
    //}
}
