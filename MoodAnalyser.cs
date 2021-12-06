using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay20
{
   public  class MoodAnalyser
    {
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad")) 
            return "SAD";
            else
                return "HAPPY";
            
        }
    }
}
