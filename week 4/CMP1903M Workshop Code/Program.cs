using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //Week 9
            //Golf Club Management
            Console.WriteLine("**Welcome to the Golf Club Membership App**");
            //List of members
            List<GolfClubMemberBase> list = new List<GolfClubMemberBase>();
            list.Add(new Member("Fred", new DateTime(1995, 01, 01)));
            list.Add(new JuniorMember("Freda", new DateTime(2004, 01, 01)));

            foreach (GolfClubMemberBase member in list)
            {

                if (member is Member)
                {
                    member.emailAlert("Member: Email message...");
                }
                if (member is JuniorMember)
                {
                    member.emailAlert("Junior Member: Email message...");
                }
            }


        }
    }
}
