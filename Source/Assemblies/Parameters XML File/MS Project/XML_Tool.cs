using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using Microsoft.Win32;



public partial class parameters
{
    //Function used to check XML File aginst XSD Schema.
    static public Boolean  ValidateAgainstXMLSchema(string XMLFilepath, string SchemaXMLFilepath)
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, SchemaXMLFilepath);
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(XMLFilepath, settings);
                XmlDocument document = new XmlDocument();
                document.Load(reader);

                  document.Validate(null);

                reader.Close();
                return true;

            }
            catch (XmlSchemaValidationException ex)
            {
            throw new ApplicationException("\n\nError: 5000, Message: Arinc-429 XML Parameters File, Reading XML.\n\nLine Number: #" + ex.LineNumber + ", Line Position: #"+ex.LinePosition +".\n\nMessage: "+ex.Message);
            }
        }
    //Function used to perform actual XML Deserialization.
    static public parameters DeserializeXML(string XMLFilepath)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(parameters));
            Stream reader1 = new FileStream(XMLFilepath, FileMode.Open);
            parameters readData = (parameters)serializer.Deserialize(reader1);
            reader1.Close();
            return readData;

        }
        catch (Exception ex)
        {
            throw new ApplicationException("\n\nError: 5001, Message: Arinc-429 XML Parameters File, XML Deserialization: " + ex.Message);
        }
    }
    static public Boolean SerializeXML(string XMLFilepath, parameters Myparameters)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(parameters));
            Stream writer = new FileStream(XMLFilepath, FileMode.OpenOrCreate);
            serializer.Serialize(writer,Myparameters);
            writer.Close();
            return true;

        }
        catch (Exception ex)
        {
            //throw new ApplicationException("\n\nError: 5002, Message: Arinc-429 XML Parameters File, XML Serialization: " + ex.Message);
            throw new ApplicationException("\n\nError: 5002, Message: Arinc-429 XML Parameters File, XML Serialization: " + ex.Message+ "\nException Type: {0}"+ex.GetType().FullName+ "\nSource: {0}"+ex.Source+ "\nStrackTrace: {0}"+ex.StackTrace+"\nTargetSite: {0}"+ex.TargetSite);
          //  Console.WriteLine("Message: {0}", ex.Message);
            //Console.WriteLine("Exception Type: {0}", ex.GetType().FullName);
            //Console.WriteLine("Source: {0}", ex.Source);
            //Console.WriteLine("StrackTrace: {0}", ex.StackTrace);
            //Console.WriteLine("TargetSite: {0}", ex.TargetSite);
        }
    }
}
