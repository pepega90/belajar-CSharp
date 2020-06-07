using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

namespace BelajarCS.CustomException
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException("User is already login");
            }
            catch(UserException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    [Serializable]
    public class UserException : Exception
    {
        public UserException() : base()
        {

        }

        public UserException(string pesan) : base(pesan)
        {

        }
        public UserException(string pesan, Exception innerEx) : base(pesan, innerEx)
        {

        }

        public UserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
