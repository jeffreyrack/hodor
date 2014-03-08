/*Team Hodor
 * 
 * THis file will provide for creating the XML file as well as updating, deleting, and retrieving information from the XML database.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections.Generic;

public class xmlBackend
{
    public xmlBackend()
    {
        //idk why this is here, just because
        //InitializeComponent();
    }

    //
    XmlDocument xDoc;
    //the file name needs to be a direct path to the file from the C drive
    string fileName = "C:\\ProgramData\\Students.xml";
    List<string> problemSet1;//list for returning the problem set
    List<string> transcribe;
    //List<int> questionTime;
    //OpenFileDialog ofd = new OpenFileDialog();
    //ofd.Filter = "XML|* .xml";


    public void saveGameStuff(int probSetId, List<int> problemSetIndex, bool isPositive, bool isAddition, int nudNumOfProb, Student stud)
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);

                XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.getId().ToString() + "']");

                XmlAttribute attr = xDoc.CreateAttribute("problemSetID");
                attr.Value = probSetId.ToString();

                XmlAttribute attr2 = xDoc.CreateAttribute("numOfProblems");
                attr2.Value = nudNumOfProb.ToString();
                XmlNode xNode;
                if (node.SelectSingleNode("problems") == null)
                {
                    xNode = xDoc.CreateElement("problems");
                }
                else
                {
                    xNode = node.SelectSingleNode("problems");
                    xNode.InnerText = "";
                }
                xNode.Attributes.Append(attr);
                xNode.Attributes.Append(attr2);
                node.AppendChild(xNode);


                for (int i = 0; i < problemSetIndex.Count; i++)
                {
                    XmlNode pNode = xDoc.CreateElement("problem");
                    pNode.InnerXml = problemSetIndex[i].ToString();
                    xNode.AppendChild(pNode) ;
                }

                XmlNode positive = xDoc.CreateElement("isPositive");
                XmlNode addition = xDoc.CreateElement("isAddition");

                positive.InnerText = isPositive.ToString();
                addition.InnerText = isAddition.ToString();

                xNode.AppendChild(positive);
                xNode.AppendChild(addition);
                xDoc.Save(fileName);
        }
    }

    //This method will create a new student in the XMl file
    public void Create(Student stud)
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);
        }
        else
        {
            XmlElement ele = xDoc.CreateElement("Students");
            xDoc.AppendChild(ele);
        }

        XmlAttribute attr = xDoc.CreateAttribute("id");
        attr.Value = stud.getId().ToString();
        XmlNode xNode = xDoc.CreateElement("Student");
        xNode.Attributes.Append(attr);
        XmlNode name = xDoc.CreateElement("Name");
        XmlNode isTeach = xDoc.CreateElement("isTeacher");

        name.InnerText = stud.getName();
        isTeach.InnerText = stud.getisTeacher().ToString();

        xNode.AppendChild(name);
        xNode.AppendChild(isTeach);
        xDoc.DocumentElement.AppendChild(xNode);
        xDoc.Save(fileName);

        //createGame(Name);
    }

    //This method will select all student nodes and return them in the XML document
    public List<Student> selectAll()
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);
        }
        else return new List<Student>();
        xDoc.Load(fileName);
        List<Student> users = new List<Student>();
        int i = 0;
        foreach (XmlNode node in xDoc.SelectNodes("Students/Student"))
        {
            String id=node.Attributes["id"].Value;
            users.Add(new Student(node.SelectSingleNode("Name").InnerText,
                node.SelectSingleNode("isTeacher").InnerText=="True", Convert.ToInt32(id)));
        }
        return users;

    }

    public Game selectStudentGameInfo(Student stud)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);
        XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.getId().ToString() + "']");
        node = node.SelectSingleNode("problems");
        if (node == null) return null;
        int i = 0;
        Game toReturn = new Game();
        List<int> questions = new List<int>();
        toReturn.setProblemSetId(Convert.ToInt32(node.Attributes["problemSetID"].Value));
        toReturn.setNumProblems(Convert.ToInt32(node.Attributes["numOfProblems"].Value));
        foreach (XmlNode studNode in node)
        {
            if (studNode.Name == "problem")
            {
                questions.Add(Convert.ToInt32(studNode.InnerText));
            }
            else if (studNode.Name == "isPositive")
            {
                toReturn.setisPositiveOnly(studNode.InnerText == "True");
            }
            else if (studNode.Name == "isAddition")
            {
                toReturn.setisAddition(studNode.InnerText == "True");
            }
        }
        toReturn.setIndex(questions);
        return toReturn;

    }

    //function to save data for a students game. 
    public void saveGameStats(List<bool> answers, List<int> index, Student stud)
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);
        }


        DateTime theDate;
        theDate = DateTime.Now;




        
         XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.getId().ToString() + "']");

            //save information
            XmlNode xNode = xDoc.CreateElement("Game");
            XmlNode indexes=xDoc.CreateElement("indexes");
            XmlNode date = xDoc.CreateElement("Date");
            XmlNode problemSetId = xDoc.CreateElement("problemSetId");
            problemSetId.InnerText = stud.getnextGame().getProblemSetId().ToString();
            xNode.AppendChild(problemSetId);
            for (int i = 0; i < index.Count; i++)
            {
                XmlNode indexNode = xDoc.CreateElement("index");
                indexNode.InnerText = index.ElementAt(i).ToString();
                indexes.AppendChild(indexNode);
            }
            xNode.AppendChild(indexes);

            node.AppendChild(xNode);
            xNode.AppendChild(date);
            date.InnerText = Convert.ToString(theDate);

            //number of elements in answers list
            int number = answers.Count;

            XmlNode game = xDoc.CreateElement("Answers");
            xNode.AppendChild(game);
            for (int i = 0; i < number; i++)
            {
                bool blarghonk = answers[i];
                XmlNode answerSet = xDoc.CreateElement("answer");
                answerSet.InnerText = Convert.ToString(blarghonk);
                game.AppendChild(answerSet);
            }
        

        xDoc.Save(fileName);

    }



    //this function returns a list of the correct probme sets, the correct problem set is
    //sent to this function as a parameter
     public List<int> selectProblemSet(int problemSet)
    {
        xDoc = new XmlDocument();
        string XML = Cycle1gui.Properties.Resources.problemSet;
        StringReader str = new StringReader(XML);
        xDoc.InnerXml = XML;
        XmlReader xmlr = XmlReader.Create(str);
        List<int> questions = new List<int>();
        //List<List<int>> questions = new List<List<int>>();
        //List<int> firstNums = new List<int>();
        //List<int> secondNums = new List<int>();
         XmlNode node;
         bool keepReading=true;
         while(keepReading){
               xmlr.Read();
               if (xmlr.NodeType == XmlNodeType.Element)
                {
                    if (xmlr.Name == "problemsetid")
                    {
                        xmlr.Read();
                        if (xmlr.Value == problemSet.ToString()) keepReading = false;
                    }
                    else if (xmlr.Name == "root" || xmlr.Name=="problemset") continue;
                    else
                   {
                       xmlr.Skip();
                   }
                }
        }
         xmlr.Read();
         keepReading = true;
         while (keepReading)
         {
             xmlr.Read();
             if (xmlr.NodeType == XmlNodeType.Element && (xmlr.Name=="num1" || xmlr.Name=="num2"))
             {
                 xmlr.Read();
                 questions.Add(Convert.ToInt32(xmlr.Value));
             }
             if (xmlr.NodeType == XmlNodeType.EndElement && xmlr.Name == "problemlist")
             {
                 return questions;
             }
         }

        return questions;
    }


     public void updateStudentName(Student stud)
     {
         xDoc = new XmlDocument();
         if (File.Exists(fileName))
         {
             xDoc.Load(fileName);
         }
         else return;

         XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.getId().ToString() + "']");
         var fillNode = node.SelectSingleNode("Name");
         fillNode.InnerText = stud.getName();
         xDoc.Save(fileName);
         return;
     }

    //this will save the game information for a user that has just done a game
    public void saveUserGame(List<string> savedGame)
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);
        }
        else
        {
            //i dont know somthing
        }

        //find the correct spot ont he XMl and save the game


        xDoc.Save(fileName);
    }


    public List<gameResults> readGameStats(Student stud)
    {
        xDoc = new XmlDocument();
        if (File.Exists(fileName))
        {
            xDoc.Load(fileName);
        }
        List<gameResults> results = new List<gameResults>();
        XmlNode studNode = xDoc.SelectSingleNode("//Student[@id='" + stud.getId().ToString() + "']");
        foreach (XmlNode node in studNode.SelectNodes("Game"))
        {
            gameResults game = new gameResults();
            game.Date = node.SelectSingleNode("Date").InnerText;
            game.problemSetId = Convert.ToInt32(node.SelectSingleNode("problemSetId").InnerText);
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.Name == "indexes")
                {
                    foreach (XmlNode index in child.ChildNodes)
                    {
                        game.indexes.Add(Convert.ToInt32(index.InnerText));
                    }
                }
                else if (child.Name == "Answers")
                {
                    foreach (XmlNode answer in child.ChildNodes)
                    {
                        game.correct.Add(answer.InnerText == "True");
                    }
                }
            }
            results.Add(game);
        }
        return results;
    }












    /*
        List<string> probSet = new List<string>();

        foreach (XmlNode node in xDoc.SelectNodes("the select nodes go here"))
        {
            //probSet.Add();//this will add the problems to the list

        }


        return problemSet1;
    }
    */




    /*
     * //Some stuff i was experimenting with
    static void setXMlStuff()
    {
        using (XmlWriter writer = XmlWriter.Create("students.xml"))
        {
 
            foreach(Student student in student)
            {
            writer.WriteStartElement("FirstTHing");
            writer.WriteElementString("Stuff");

            writer.WriteEndElement();
            }

        writer.WriteEndElement();
        writer.WriteEndDocument();

        }
    }
    */

    /*
    //This method will update a students node
    public void Update(string original, string Name, bool isTeacher)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);

        foreach (XmlNode node in fileName.SelectNodes("Students/Student"))
        {
            if (node.SelectSingleNode("Name").InnerText == original)
            {
                xDoc.SelectSingleNode("Students/Student/Name") = Name;
                xDoc.SelectSingleNode("Students/Student/isTeacher") = isTeacher;
                xDoc.Save(fileName);
            }
        }

        //updateGame(Name);
    }

    //This method will delete a single node fromt he XMl document
    public void Delete(string original, string Name)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);

        foreach (XmlNode xNode in xDoc.SelectNodes("Students/Student"))
        {
            if (xNode.SelectSingleNode("Name").InnerText == Name)
            {
                xNode.ParentNode.RemoveChild(xNode);
            }
            xDoc.Save(fileName);
        }

        //deleteGame(Name);

    }

    //This method will create a new student in the XMl file
    public void Create(string Names, bool isTeachers)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);

        XmlNode xNode = xDoc.CreateElement("Student");

        XmlNode name = xDoc.CreateElement("Name");
        XmlNode isTeach = xDoc.CreateElement("isTeacher");

        name = Names;
        isTeach = isTeachers;
        //add the game backend stuff here and append to new student
        xNode.AppendChild(name);
        xNode.AppendChild(isTeach);
        xDoc.DocumentElement.AppendChild(Student);
        xDoc.Save(fileName);

        //createGame(Name);
    }

    //This method will select a specific person from the students XMl document and return the student.
    public void selectSpecific(string Name, bool isTeacher)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);

        foreach (XmlNode xNode in fileName.SelectNodes("Students/Student"));
        if(xNode.SelectSingleNode("Name" == Name);

        //do somthing with returning xNode specific student
        xDoc.Save(fileName);

    }





    /*
    public static void updateGame(string name)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);


    }


    public static void createGame(string name)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);


    }

    
    public static void deleteGame(string name)
    {
        xDoc = new XmlDocument();
        xDoc.Load(fileName);

    }

    
    public static void updateGame()
    {

    }
    */


}