using System.Collections.Generic;

namespace ADSQuizMachine
{
    public static class GlobalVariables
    {
        public static int CurrentQuestion = 0;
        public static int CorrectAnswers = 0;
        public static int TotalQuestions = 13;
        public static HashSet<string> AskedQuestions = new HashSet<string>();
    }
}
