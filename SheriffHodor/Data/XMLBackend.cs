/* XmlBackend.cs
 * Purpose: Handles the reads/writes to the xml file.
 * 
 * Version - 3.0.0 - Cycle 2 Release
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
    /// <summary>
    /// Provides serialization helper for the Xml file.
    /// All the 
    /// </summary>
    public static class XmlBackend
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
            try
            {
                Validate(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //TODO currently doesn't work with no .xml file in said path
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
            try
            {
                using (var reader = XmlReader.Create(path, settings))
                {
                    while (reader.Read())
                        ;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                //TODO create the Directory and xml file [and load it with a default user?]
                MessageBox.Show(ex.ToString());
            }
            catch (FileNotFoundException ex)
            {
                //TODO create the xml file [and load it with a default user?]
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Read & Write
        /// <summary>
        /// Load an XML file without prior validation.
        /// </summary>
        /// <param name="path">A valid path to the XML file.</param>
        /// <returns>An instance of XmlReader representing the file loaded.</returns>
        private static XmlReader LoadReaderUnchecked(string path)
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
        private static XmlReader LoadReader(string path)
        {
            Validate(path);
            return LoadReaderUnchecked(path);
        }
        /// <summary>
        /// Generic Deserializer.
        /// </summary>
        /// <typeparam name="T">A root class to deserialize.</typeparam>
        /// <param name="path">A path to the XML file.</param>
        /// <param name="defaultData">When != null, checks for the existence of the file, and create / fill.</param>
        /// <returns>A newly instantiated class of type T.</returns>
        public static T Deserialize<T>(string path, string[] defaultData = null) where T : class
        {
            // Create the file if it doesn't exist
            if (defaultData != null && !File.Exists(path))
            {
                Directory.CreateDirectory(Global.ConfDirPath);
                using (var defaultFile = File.CreateText(path))
                    foreach (var str in defaultData)
                        defaultFile.WriteLine(str);
            }
            // Read the file and deserialize it.
            using (var reader = XmlBackend.LoadReader(path))
            {
                if (reader == null)
                    throw new FileNotFoundException("LoadReader failed (returned null)");
                var Serializer = new XmlSerializer(typeof(T));
                var list = Serializer.Deserialize(reader) as T;
                reader.Close();
                return list;
            }
        }
        /// <summary>
        /// Generic Serializer.
        /// </summary>
        /// <typeparam name="T">A root class to serialize.</typeparam>
        /// <param name="path">A path to the XML file.</param>
        /// <param name="item">The object to serialize.</param>
        public static void Serialize<T>(string path, T item) where T : class
        {
            var serializer = new XmlSerializer(typeof(T));
            if (!File.Exists(path))
                Directory.CreateDirectory(Global.ConfDirPath);
            using (var writer = File.CreateText(path))
            {
                serializer.Serialize(writer, item);
                writer.Close();
            }
        }
        #endregion
    }
}
