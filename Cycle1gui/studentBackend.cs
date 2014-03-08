/*Team Hodor
 * This file provides the Getters and Seters of the below data list
 * 
 */
using System;
using System.Collections.Generic;

public class Student : User
{
    public Student()
    {

    }

	public Student(String name, bool isTeacher, int id) 
	{
        this.setName(name);
        this.setisTeacher(isTeacher);
        this.id = id;
        if (id > maxId) maxId = id;
	}

    public bool isTeacher = false;

    private Game nextGame;

    private List<Game> report;

    public static int maxId = 0;
    public int id;

    //getters and setters
    public bool getisTeacher()
    {
        return isTeacher;
    }

    public Game getnextGame()
    {
        return nextGame;
    }

    public Game getreport(int number)
    {
        return report[number];
    }

    public int getId()
    {
        return this.id;
    }

    //Setter
    public void setisTeacher(bool isTeacher)
    {
        this.isTeacher = isTeacher;
    }

    public void setnextGame(Game nextGame)
    {
        this.nextGame = nextGame;
    }

    public void setreport(int number)
    {
        this.report[number] = report[number];
    }

    public static Student authenticate_User(List<Student> users, String username)
    {
        Student selectedUser = new Student();
        foreach (Student user in users)
        {
            if (user.getName() + " " + user.getId() == username)
            {
                selectedUser = user;
                break;
            }
        }
        return selectedUser;
    }
       
}


