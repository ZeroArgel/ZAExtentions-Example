namespace ZAExtentions_Example
{
    using System;
    using ZAExtensions;
    using static ZAExtensions.ToEnums;
    class Program
    {
        static void Main(string[] args)
        {
            ToConversions();
        }
        static void ToConnectionApi()
        {

        }
        #region All methods for conversion.
        static void ToConversions()
        {
            #region Declaration of:
            char chrTest = 'A'; // char.
            int intTest = 10; // int.
            string strTest = "10"; // string.
            long longTest = 10; // long.
            decimal decTest = 1/2; // decimal.
            float fltTest = 1/4; // float.
            double doblTest = 10.1; // double.
            bool boolTest = true; // bool.
            object objTest = 20; // object.
            byte[] byteTest = { 0, 2 }; // byteTest
            #endregion

            #region All methods for convert some variable to Int32.
            Console.WriteLine("Extension methods ToInt().");
            Console.WriteLine($"string to int: { strTest.ToInt() }, Type: { strTest.ToInt().GetType() }"); // string to int.
            Console.WriteLine($"decimal to int: { decTest.ToInt() }, Type: { decTest.ToInt().GetType() }"); // decimal to int.
            Console.WriteLine($"float to int: { fltTest.ToInt() }, Type: { fltTest.ToInt().GetType() }"); // float to int.
            Console.WriteLine($"double to int: { doblTest.ToInt() }, Type: { doblTest.ToInt().GetType() }"); // double to int.
            Console.WriteLine($"object to int: { objTest.ToInt() }, Type: { objTest.ToInt().GetType() }"); // object to int.
            Console.WriteLine($"byte[] to int: { byteTest.ToInt() }, Type: { byteTest.ToInt().GetType() }"); // byte[] to int.
            #endregion

            #region All methods for convert some variable to long or Int64.
            Console.WriteLine("Extension methods ToLong()");
            Console.WriteLine($"string to long { strTest.ToLong() }, Type: { strTest.ToLong().GetType() }"); // string to long.
            Console.WriteLine($"object to long { objTest.ToLong() }, Type: { objTest.ToLong().GetType() }"); // object to long.
            Console.WriteLine($"byte[] to long { byteTest.ToLong() }, Type: { byteTest.ToLong().GetType() }"); // byte[] to long.
            #endregion

            #region All methods for convert some variable to Guid.
            Console.WriteLine("Extension methods ToGuid()");
            Console.WriteLine($"object to Guid { objTest.ToGuid() }, Type: { objTest.ToGuid().GetType() }");
            #endregion

            // All methods for convert some variable to decimal.
            Console.WriteLine($"string to decimal { strTest.ToDecimal(Cultures.EN_US) }, Type: { strTest.ToDecimal(Cultures.EN_US).GetType() }"); // string to long.

            #region All methods for convert some variable to DateTime.
            Console.WriteLine($"string to DateTime { strTest.ToDateTime(Cultures.EN_US) }, Type: { strTest.ToDateTime(Cultures.EN_US).GetType() }"); // string to DateTime.
            Console.WriteLine($"string to DateTime { longTest.ToDateTime() }, Type: { longTest.ToDateTime().GetType() }"); // long to DateTime.
            #endregion

            // All methods for convert some variable to bool.
            Console.WriteLine($"string to bool { strTest.ToBoolean() }, Type: { strTest.ToBoolean().GetType() }"); // string to bool.

            #region All methods for convert some variable to byte[].
            Console.WriteLine($"bool to byte[] { boolTest.ToByte() }, Type: { boolTest.ToByte().GetType() }"); // bool to byte[].
            Console.WriteLine($"char to byte[] { chrTest.ToByte() }, Type: { chrTest.ToByte().GetType() }"); // char to byte[].
            Console.WriteLine($"int to byte[] { intTest.ToByte() }, Type: { intTest.ToByte().GetType() }"); // int to byte[].
            Console.WriteLine($"long to byte[] { longTest.ToByte() }, Type: { longTest.ToByte().GetType() }"); // long to byte[].
            #endregion
        }
        #endregion
    }
}
