/*Team Hodor
 * 
 * THis file will provide for creating the XML file as well as updating, deleting, and retrieving information from the XML database.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace CSUSM.CS441.SheriffHodor.Data
{
    public static class XMLBackend
    {
        #region Validation
        /// <summary>
        /// Check whenever a config file is valid, according to it's DTD.
        /// </summary>
        /// <param name="path">A path to the config file to check.
        /// Note that an invalid path will be treated as invalid.</param>
        /// <returns>True if the file exist and is valid.</returns>
        public static bool IsValid(string path)
        {
            try {
                Validate(path);
                return true;
            } catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// Check whenever a config file is valid, according to it's DTD.
        /// If a validation error happens, an exception is throw.
        /// </summary>
        /// <param name="path">A path to the file to validate.</param>
        public static void Validate(string path)
        {
            var settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            //settings.ValidationType = ValidationType.None;
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            var reader = XmlReader.Create(path, settings);
            while (reader.Read())
                ;
        }
        #endregion
        #region Read
        /// <summary>
        /// Load an XML file without prior validation.
        /// </summary>
        /// <param name="path">A valid path to the XML file.</param>
        /// <returns>An instance of XmlReader representing the file loaded.</returns>
        public static XmlReader LoadReaderUnchecked(string path)
        {
            var settings = new XmlReaderSettings();
            // .NET Framework 4.0
            settings.DtdProcessing = DtdProcessing.Ignore;
            settings.ValidationType = ValidationType.None;
            return XmlReader.Create(path, settings);
        }
        /// <summary>
        /// Validate an XML file then load it.
        /// </summary>
        /// <param name="path">A valid path to the XML file.</param>
        /// <returns>An instance of XmlReader representing the file loaded.</returns>
        public static XmlReader LoadReader(string path)
        {
            Validate(path);
            return LoadReaderUnchecked(path);
        }
        #endregion

        public static void saveGameStuff(int probSetId, List<int> problemSetIndex, bool isPositive,
            bool isAddition, int nudNumOfProb, User stud)
        {
            if (!File.Exists(Global.UsersFilePath))
                return;
            var xDoc = new XmlDocument();
            xDoc.Load(Global.UsersFilePath);

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
            xDoc.Save(Global.UsersFilePath);
        }

        //This method will create a new student in the XML file
        public static void Create(User stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Global.UsersFilePath)) {
                xDoc.Load(Global.UsersFilePath);
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
            isTeach.InnerText = (stud.Status == User.UserType.Teacher).ToString();

            xNode.AppendChild(name);
            xNode.AppendChild(isTeach);
            xDoc.DocumentElement.AppendChild(xNode);
            xDoc.Save(Global.UsersFilePath);

            //createGame(Name);
        }

        public static Game selectStudentGameInfo(User stud)
        {
            var xDoc = new XmlDocument();
            xDoc.Load(Global.UsersFilePath);
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
        public static void saveGameStats(List<bool> answers, List<int> index, User stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Global.UsersFilePath)) {
                xDoc.Load(Global.UsersFilePath);
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
            xDoc.Save(Global.UsersFilePath);
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


        public static void updateStudentName(User stud)
        {
            var xDoc = new XmlDocument();
            if (!File.Exists(Global.UsersFilePath))
                return;

            xDoc.Load(Global.UsersFilePath);
            XmlNode node = xDoc.SelectSingleNode("//Student[@id='" + stud.Id.ToString() + "']");
            var fillNode = node.SelectSingleNode("Name");
            fillNode.InnerText = stud.Name;
            xDoc.Save(Global.UsersFilePath);
        }

        //this will save the game information for a user that has just done a game
        public static void saveUserGame(List<string> savedGame)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Global.UsersFilePath)) {
                xDoc.Load(Global.UsersFilePath);
            } else {
                //i dont know somthing
            }

            //find the correct spot ont he XMl and save the game
            xDoc.Save(Global.UsersFilePath);
        }


        public static List<gameResults> readGameStats(User stud)
        {
            var xDoc = new XmlDocument();
            if (File.Exists(Global.UsersFilePath)) {
                xDoc.Load(Global.UsersFilePath);
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
