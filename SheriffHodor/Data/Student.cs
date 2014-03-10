/*Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public class Student : User
    {
        public Student() { this.isTeacher = false; }
        public Student(String name, bool isTeacher, int id)
        {
            this.Name = name;
            this.isTeacher = isTeacher;
            this.Id = id;
            if (id > maxId)
                maxId = id;
        }

        public bool isTeacher { get; set; }
        public static int maxId = 0;
        public Game nextGame { get; set; }
        public List<Game> report { get; set; }

        public static Student authenticate_User(List<Student> users, String username)
        {
            Student selectedUser = new Student();
            foreach (Student user in users) {
                if (user.Name + " " + user.Id == username) {
                    selectedUser = user;
                    break;
                }
            }
            return selectedUser;
        }

    }
}