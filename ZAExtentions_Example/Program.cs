namespace ZAExtentions_Example
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using ZAExtensions;
    using static ZAExtensions.ToEnums;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //ToConversions();
            //ToEncrypts();
            //ToEnums();
            //ToManyExtensions();
            //ToJsons();
            StandardReturn();
            //ToTokens();
        }
        static void ToConnectionApi()
        {
        }
        #region All methods for conversion.
        static void ToConversions()
        {
            #region Declaration of:
            var dateHr = DateTime.Now.Hour; // hour of day.
            char chrTest = 'A'; // char.
            int intTest = 10; // int.
            string strTest = "10"; // string.
            string strDateTest = "10/10/2001"; // string to test ToDateTime extension.
            string strBoolTest = "True"; // string to test ToBool extension.
            long longTest = 10; // long.
            decimal decTest = 1/2; // decimal.
            float fltTest = 1/4; // float.
            double doblTest = 10.1; // double.
            bool boolTest = true; // bool.
            object objTest = 20; // object.
            object objTestGuid = Guid.NewGuid(); // object to test ToGuid extension.
            byte[] byteTest = { 2 }; // byteTest
            var listStrTest = new List<string>() { "1", "2", "3", "4" }.AsEnumerable(); // IEnumerable<string>.
            var IEnumerableStrTest = new List<string>() { "1", "2", "3", "4" }; // List<string>.
            #endregion

            #region All methods for convert some variable to Int32.
            Console.WriteLine("Extension methods ToInt().");
            Console.WriteLine($"string to int: { strTest.ToInt() }, Type: { strTest.ToInt().GetType() }"); // string to int.
            Console.WriteLine($"decimal to int: { decTest.ToInt() }, Type: { decTest.ToInt().GetType() }"); // decimal to int.
            Console.WriteLine($"float to int: { fltTest.ToInt() }, Type: { fltTest.ToInt().GetType() }"); // float to int.
            Console.WriteLine($"double to int: { doblTest.ToInt() }, Type: { doblTest.ToInt().GetType() }"); // double to int.
            Console.WriteLine($"object to int: { objTest.ToInt() }, Type: { objTest.ToInt().GetType() }"); // object to int.
            #endregion

            #region All methods for convert some variable to long or Int64.
            Console.WriteLine("Extension methods ToLong()");
            Console.WriteLine($"string to long { strTest.ToLong() }, Type: { strTest.ToLong().GetType() }"); // string to long.
            Console.WriteLine($"object to long { objTest.ToLong() }, Type: { objTest.ToLong().GetType() }"); // object to long.
            #endregion

            #region All methods for convert some variable to Guid.
            Console.WriteLine("Extension methods ToGuid()");
            Console.WriteLine($"object to Guid { objTestGuid.ToGuid() }, Type: { objTestGuid.ToGuid().GetType() }"); 
            #endregion

            // All methods for convert some variable to decimal.
            Console.WriteLine($"string to decimal { strTest.ToDecimal(Cultures.EN_US) }, Type: { strTest.ToDecimal(Cultures.EN_US).GetType() }"); // string to long.

            #region All methods for convert some variable to DateTime.
            Console.WriteLine($"string to DateTime { strDateTest.ToDateTime(Cultures.EN_US) }, Type: { strDateTest.ToDateTime(Cultures.EN_US).GetType() }"); // string to DateTime.
            Console.WriteLine($"string to DateTime { longTest.ToDateTime() }, Type: { longTest.ToDateTime().GetType() }"); // long to DateTime.
            #endregion

            // All methods for convert some variable to bool.
            Console.WriteLine($"string to bool { strBoolTest.ToBoolean() }, Type: { strBoolTest.ToBoolean().GetType() }"); // string to bool.

            #region All methods for convert some variable to byte[].
            Console.WriteLine($"bool to byte[] { boolTest.ToByte() }, Type: { boolTest.ToByte().GetType() }"); // bool to byte[].
            Console.WriteLine($"char to byte[] { chrTest.ToByte() }, Type: { chrTest.ToByte().GetType() }"); // char to byte[].
            Console.WriteLine($"int to byte[] { intTest.ToByte() }, Type: { intTest.ToByte().GetType() }"); // int to byte[].
            Console.WriteLine($"long to byte[] { longTest.ToByte() }, Type: { longTest.ToByte().GetType() }"); // long to byte[].
            #endregion

            #region All methods for convert some variable to base64.
            Console.WriteLine($"string to base64 { strBoolTest.ToBase64() }, Type: { strBoolTest.ToBase64().GetType() }"); // string to base64.
            Console.WriteLine($"byte[] to base64 { byteTest.ToBase64() }, Type: { byteTest.ToBase64().GetType() }"); // byte[] to base64.
            #endregion

            #region another methods to converts.
            Console.WriteLine($"Delete spaces 1 2 3 4 to { "1 2 3 4".ToReplaceAll() }, Type: { "1 2 3 4".ToReplaceAll().GetType() }"); // Delete spaces.            
            Console.WriteLine($"List concat with commas { listStrTest.ToConcat() }, Type: { listStrTest.GetType() }"); // List concat with commas.
            Console.WriteLine($"IEnumerable concat with commas { IEnumerableStrTest.ToConcat() }, Type: { IEnumerableStrTest.GetType() }"); // IEnumerable concat with commas.
            #endregion

            Console.WriteLine("0 - Morning. 1 - Afternoon. 2 - Evening. 3 - Night.");
            Console.WriteLine($"{ dateHr.ToGreeting() }"); // Get a datecurrent in number.
        }
        #endregion
        #region All methods for encrypts.
        static void ToEncrypts()
        {
            var password = "contraseñaSegura";
            var passBase64 = password.ToEncode64();
            Console.WriteLine($"password with ToHash(): { password.ToHash() }");
            Console.WriteLine($"password with encode base64: { passBase64 }");
            Console.WriteLine($"password with decode base64: { passBase64.ToDecode64() }");
        }
        #endregion
        #region All Enums.
        static void ToEnums()
        {
            Console.WriteLine($"Country code of spain: { Countries.Spain.ToNumber() }");
            Console.WriteLine($"ISO Code of méxico: { Countries.Mexico.ToDescription() }");
            Console.WriteLine($"Search name of méxico by ISO Code: { Countries.Mexico.ToDescription().ToEnumValue<Countries>() }");
        }
        #endregion
        #region Many extensions methods.
        static void ToManyExtensions()
        {
            // Declarations of:
            var model = new ExampleModel(1, "Test");
            var iEnumerableModel = new List<ExampleModel>() { model };

            Console.WriteLine($"Has a model: { model.HasEmptyModel() }");
            Console.WriteLine($"Has a IEnumerable<model> { iEnumerableModel.HasEmptyModel() }");
            Console.WriteLine($"Is empty model: { model.IsEmptyModel() }");
        }
        #endregion
        #region Methods to serialize and deserialize in json.
        static void ToJsons()
        {
            var jsonString = new ExampleModel(1, "Test").ToSerialize();
            Console.WriteLine($"Serialize ExampleModel: { jsonString }");
            Console.WriteLine($"Deserialize ExampleModel: { jsonString.ToDeserialize<ExampleModel>() }");
            Console.WriteLine($"Serialize/Deserialize ExampleModel: { new ExampleModel(2, "Hola").ToSerializeDeserialize<ExampleModel, ExampleModelJson>() }");
        }
        #endregion
        #region Methods to standard return.
        static void StandardReturn()
        {
            var tROk = new ExampleModel(1, "Test").TROk();
            var tRBad = "Error".TRBad();
            var tRUnauthorized = "".TRUnauthorized();
            var tRUnauthorizedMessage = "Error".TRUnauthorized();
            Console.WriteLine($"Standard return Ok request: { tROk.ToSerialize() }");
            Console.WriteLine($"Standard return Bad request: { tRBad.ToSerialize() }");
            Console.WriteLine($"Standard return Unauthorized request: { tRUnauthorized.ToSerialize() }");
            Console.WriteLine($"Standard return Unauthorized Message request: { tRUnauthorizedMessage.ToSerialize() }");
        }
        #endregion
        #region ToTokens
        #endregion
    }
}