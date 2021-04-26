using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QPL.Models
{
    public class UserLogin
    {
        public string NT_ID { get; set; }
        public string Password { get; set; }        
    }

    public class UserSignUp
    {
        public string NT_ID { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }

    }
    // GET Api/MatchPrediction/GetCurrentMatchDetails
    public class CurrentMatchDetails
    {
        public int MatchFixtureId { get; set; }
        public string MatchDate { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }

    }

    public class MatchPrediction
    {
        public string NT_ID { get; set; }
        public string Stage1WinnerTeam { get; set; }
        public string Stage3WinnerTeam { get; set; }
        public string Stage2WinnerTeam { get; set; }
        public string WinnerTeam { get; set; }        

    }
}