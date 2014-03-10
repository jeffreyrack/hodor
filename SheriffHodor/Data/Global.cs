using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CSUSM.CS441.SheriffHodor.Data
{
    /// <summary>
    /// Hold a state global to the program.
    /// As our application is single threaded, we can hold pretty much everything this way.
    /// Centralizing data here allow for an easyier development path, easyier maintenance and enhance writtability.
    /// This is a design choice, considering we have a small-scale application, we're not over-engineering it.
    /// </summary>
    public static class Global
    {
        #region Refactor
        public static int maxId = 0;
        #endregion

        #region Const data
        public const string StudentFilePath = @"C:\ProgramData\Students.xml";
        #endregion

        #region UserList
        [XmlRoot("Students")]
        public class SerializableUserList
        {
            [XmlElement("Student")]
            public List<User> Users = new List<User>();
        }

        /// <summary>
        /// Get a list of the users.
        /// This list is stored in the XML file in the backend.
        /// </summary>
        public static IList<User> UserList
        {
            get
            {
                if (_userList == null)
                    _userList = InitializeUserList();
                return _userList.Users;
            }
        }
        private static SerializableUserList _userList;
        private static SerializableUserList InitializeUserList()
        {
            var reader = XmlBackend.LoadReader(Global.StudentFilePath);
            if (reader == null)
                throw new FileNotFoundException("LoadReader failed (returned null)");
            var Serializer = new XmlSerializer(typeof(SerializableUserList));
            var list = Serializer.Deserialize(reader) as SerializableUserList;
            reader.Close();
            Console.WriteLine("Deserialized {0} entities :", list.Users.Count());
            foreach (var u in list.Users)
                Console.WriteLine(u);
            return list;
        }
        #endregion
    }
}
