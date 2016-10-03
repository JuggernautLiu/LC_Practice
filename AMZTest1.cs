using System;
using System.Collections.Generic;
using System.Linq;

/*
 * using System;
 * using System.Collections.Generic;
 * using System.IO;
 * using System.Linq;
 *
 * public List<string> getDirectFriendsForUser(string user)
 *
 * public List<string> getAttendedCoursesForUser(string user)
 *
 * Please complete the method below
 */

namespace LC_Practice
{   public class AMZTest1   
    {
        public List<string> getDirectFriendsForUser(string user)
        {
            return new List<string>();
        }
        public List<string> getAttendedCoursesForUser(string user)
        {
            return new List<string>();
        }
        public List<string> getRankedCourses(string user) 
        {
            Dictionary<string,int> recommendedCourseDic = new Dictionary<string,int>();
    
            // Get My Class First
            HashSet<string> MyCourses = new HashSet<string>();
            List<string> MyCoursesList = getAttendedCoursesForUser(user);
            foreach(string course in MyCoursesList)
            {
                Console.WriteLine("My course:{0}",course);
                MyCourses.Add(course);
            }
            
            // Get My Friend
            List<string> MyFriends = getDirectFriendsForUser(user);
            foreach(string friend in MyFriends)
            {
                List<string> friendCourseList = getAttendedCoursesForUser(friend);
                foreach(string friendcourse in friendCourseList)
                {
                    Console.WriteLine("{0} course:{1}",friend, friendcourse);
                    if(!MyCourses.Contains(friendcourse))
                    {
                        if(recommendedCourseDic.ContainsKey(friendcourse))
                        {
                            recommendedCourseDic[friendcourse]++;
                        }
                        else
                        {
                            recommendedCourseDic.Add(friendcourse,1);
                        }
                    }
                }
            }
    
            var MySortedValue = (from dic in recommendedCourseDic orderby dic.Value descending select dic.Key).ToList();
            //MyCoursesList = recommendedCourseDic.Keys.ToList();
            return MySortedValue;
        }
    }
}


