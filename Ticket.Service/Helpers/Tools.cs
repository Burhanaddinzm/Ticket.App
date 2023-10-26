
//namespace Ticket.Service.Helpers
//{
//    public static class Tools
//    {
//        public static void BinarySearch(dynamic Value, int id, int endindex)
//        {
//            int startIndex = 0;
//            int endIndex = endindex - 1;
//            bool found = false;
//            while (startIndex <= endIndex)
//            {
//                int Middle = (startIndex + endIndex) / 2;
//                if (Value == id)
//                {
//                    Value = id;
//                    found = true;
//                    break;
//                }
//                else if (Value[Middle].Id < id)
//                {
//                    startIndex = Middle + 1;
//                }
//                else
//                {
//                    endIndex = Middle - 1;
//                }

//            }
//            if (!found)
//            {
//                Console.WriteLine("This ticket does not exist");
//            }
//        }
//    }
//}
