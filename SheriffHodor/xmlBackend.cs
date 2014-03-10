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

namespace CSUSM.CS441.SheriffHodor
{
    public static class XmlBackend
    {
        public static void saveGameStuff(int probSetId, List<int> problemSetIndex, bool isPositive,
            bool isAddition, int nudNumOfProb, Data.Student stud)
        {
            if (!File.Exists(Data.Global.StudentFilePath))
                return;
            var xDoc = new XmlDocument();
            xDoc.Load(Data.Global.StudentFilePath);

            XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");

            XmlAttribute attr = xDoc.CreateAttribute("problemSetID");
            attr.Value = probSetId.ToString();

            XmlAttribute attr2 = xDoc.CreateAttribute("numOfProblems");
            attr2.Value = nudNumOfProb.ToString();
            XmlNode xNode;
            if (node.SelectSingleNode("problems") == null) {
                xNode = xDoc.CreateElement("problems");
            } else {
                xNode = node.SelectSingleNode("problems");
                xNode.InnerText = "";
            }
            xNode.Attributes.Append(attr);
            xNode.Attributes.Append(attr2);
            node.AppendChild(xNode);


            for (int i = 0; i < problemSetIndex.Count; i++) {
                XmlNode pNode = xDoc.CreateElement("problem");
                pNode.InnerXml = problemSetIndex[i].ToString();
                xNode.AppendChild(pNode);
            }

            XmlNode positive = xDoc.CreateElement("isPositive");
            XmlNode addition = xDoc.CreateElement("isAddition");

            positive.InnerText = isPositive.ToString();
            addition.InnerText = isAddition.ToString();

            xNode.AppendChild(positive);
            xNode.AppendChild(addition);
            xDoc.Save(Data.Global.StudentFilePath);
        }

        //This method will create a new student in the XMl file
        public static void Create(Data.Student stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Data.Global.StudentFilePath)) {
                xDoc.Load(Data.Global.StudentFilePath);
            } else {
                XmlElement ele = xDoc.CreateElement("Students");
                xDoc.AppendChild(ele);
            }

            XmlAttribute attr = xDoc.CreateAttribute("id");
            attr.Value = stud.Id.ToString();
            XmlNode xNode = xDoc.CreateElement("Student");
            xNode.Attributes.Append(attr);
            XmlNode name = xDoc.CreateElement("Name");
            XmlNode isTeach = xDoc.CreateElement("isTeacher");

            name.InnerText = stud.Name;
            isTeach.InnerText = stud.isTeacher.ToString();

            xNode.AppendChild(name);
            xNode.AppendChild(isTeach);
            xDoc.DocumentElement.AppendChild(xNode);
            xDoc.Save(Data.Global.StudentFilePath);

            //createGame(Name);
        }

        //This method will select all student nodes and return them in the XML document
        public static List<Data.Student> selectAll__()
        {
            var users = new List<Data.Student>();
            if (!File.Exists(Data.Global.StudentFilePath))
                return users;

            var xDoc = new XmlDocument();
            xDoc.Load(Data.Global.StudentFilePath);
            foreach (XmlNode node in xDoc.SelectNodes("Students/Student")) {
                string id = node.Attributes["id"].Value;
                var tmp = new Data.Student(
                    node.SelectSingleNode("Name").InnerText,
                    node.SelectSingleNode("isTeacher").InnerText.Equals("True"),
                    Convert.ToInt32(id));
                Console.WriteLine("[{0}] => {1} is a {2}.", tmp.Id, tmp.Name, (tmp.isTeacher) ? ("teacher") : ("student"));
                users.Add(tmp);
            }
            return users;
        }

        public static Game selectStudentGameInfo(Data.Student stud)
        {
            var xDoc = new XmlDocument();
            xDoc.Load(Data.Global.StudentFilePath);
            XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");
            node = node.SelectSingleNode("problems");
            if (node == null)
                return null;
            Game toReturn = new Game();
            List<int> questions = new List<int>();
            toReturn.setProblemSetId(Convert.ToInt32(node.Attributes["problemSetID"].Value));
            toReturn.setNumProblems(Convert.ToInt32(node.Attributes["numOfProblems"].Value));
            foreach (XmlNode studNode in node) {
                if (studNode.Name == "problem") {
                    questions.Add(Convert.ToInt32(studNode.InnerText));
                } else if (studNode.Name == "isPositive") {
                    toReturn.setisPositiveOnly(studNode.InnerText == "True");
                } else if (studNode.Name == "isAddition") {
                    toReturn.setisAddition(studNode.InnerText == "True");
                }
            }
            toReturn.setIndex(questions);
            return toReturn;

        }

        //function to save data for a students game. 
        public static void saveGameStats(List<bool> answers, List<int> index, Data.Student stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Data.Global.StudentFilePath)) {
                xDoc.Load(Data.Global.StudentFilePath);
            }

            DateTime theDate;
            theDate = DateTime.Now;

            XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");

            //save information
            XmlNode xNode = xDoc.CreateElement("Game");
            XmlNode indexes = xDoc.CreateElement("indexes");
            XmlNode date = xDoc.CreateElement("Date");
            XmlNode problemSetId = xDoc.CreateElement("problemSetId");
            problemSetId.InnerText = stud.nextGame.getProblemSetId().ToString();
            xNode.AppendChild(problemSetId);
            for (int i = 0; i < index.Count; i++) {
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
            for (int i = 0; i < number; i++) {
                bool blarghonk = answers[i];
                XmlNode answerSet = xDoc.CreateElement("answer");
                answerSet.InnerText = Convert.ToString(blarghonk);
                game.AppendChild(answerSet);
            }
            xDoc.Save(Data.Global.StudentFilePath);
        }

        //this function returns a list of the correct probme sets, the correct problem set is
        //sent to this function as a parameter
        public static List<int> selectProblemSet(int problemSet)
        {
            var xDoc = new XmlDocument();
            string XML = Properties.Resources.problemSet;
            StringReader str = new StringReader(XML);
            xDoc.InnerXml = XML;
            XmlReader xmlr = XmlReader.Create(str);
            List<int> questions = new List<int>();
            //List<List<int>> questions = new List<List<int>>();
            //List<int> firstNums = new List<int>();
            //List<int> secondNums = new List<int>();
            bool keepReading = true;
            while (keepReading) {
                xmlr.Read();
                if (xmlr.NodeType == XmlNodeType.Element) {
                    if (xmlr.Name == "problemsetid") {
                        xmlr.Read();
                        if (xmlr.Value == problemSet.ToString())
                            keepReading = false;
                    } else if (xmlr.Name == "root" || xmlr.Name == "problemset")
                        continue;
                    else {
                        xmlr.Skip();
                    }
                }
            }
            xmlr.Read();
            keepReading = true;
            while (keepReading) {
                xmlr.Read();
                if (xmlr.NodeType == XmlNodeType.Element && (xmlr.Name == "num1" || xmlr.Name == "num2")) {
                    xmlr.Read();
                    questions.Add(Convert.ToInt32(xmlr.Value));
                }
                if (xmlr.NodeType == XmlNodeType.EndElement && xmlr.Name == "problemlist") {
                    return questions;
                }
            }

            return questions;
        }


        public static void updateStudentName(Data.Student stud)
        {
            var xDoc = new XmlDocument();
            if (!File.Exists(Data.Global.StudentFilePath))
                return;

            xDoc.Load(Data.Global.StudentFilePath);
            XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");
            var fillNode = node.SelectSingleNode("Name");
            fillNode.InnerText = stud.Name;
            xDoc.Save(Data.Global.StudentFilePath);
        }

        //this will save the game information for a user that has just done a game
        public static void saveUserGame(List<string> savedGame)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Data.Global.StudentFilePath)) {
                xDoc.Load(Data.Global.StudentFilePath);
            } else {
                //i dont know somthing
            }

            //find the correct spot ont he XMl and save the game
            xDoc.Save(Data.Global.StudentFilePath);
        }


        public static List<gameResults> readGameStats(Data.Student stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Data.Global.StudentFilePath)) {
                xDoc.Load(Data.Global.StudentFilePath);
            }
            List<gameResults> results = new List<gameResults>();
            XmlNode studNode = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");
            foreach (XmlNode node in studNode.SelectNodes("Game")) {
                gameResults game = new gameResults();
                game.Date = node.SelectSingleNode("Date").InnerText;
                game.problemSetId = Convert.ToInt32(node.SelectSingleNode("problemSetId").InnerText);
                foreach (XmlNode child in node.ChildNodes) {
                    if (child.Name == "indexes") {
                        foreach (XmlNode index in child.ChildNodes) {
                            game.indexes.Add(Convert.ToInt32(index.InnerText));
                        }
                    } else if (child.Name == "Answers") {
                        foreach (XmlNode answer in child.ChildNodes) {
                            game.correct.Add(answer.InnerText == "True");
                        }
                    }
                }
                results.Add(game);
            }
            return results;
        }
    }
}
