using System.Net.Sockets;
using Microsoft.AspNetCore.Components;
using Quizzing.Models;

namespace Quizzing.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<string> answeredList = new List<string>(); 
        protected int questionIndex = 0;
        protected int score = 0;
        
        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].Answer)
            {
                score++;
                
            }
            answeredList.Add(option);
            questionIndex++;
        }

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex = 0;
            answeredList.Clear();
        }

        private void LoadQuestions()
{
    Question q1 = new Question
    {
        QuestionTitle = "Who is the leader of the Minions?",
        Options = new List<string>() { "Bob", "Kevin", "Stuart", "Dave" },
        Answer = "Kevin"
    };

    Question q2 = new Question
    {
        QuestionTitle = "What is the favorite food of the Minions?",
        Options = new List<string>() { "Banana", "Pizza", "Ice Cream", "Tacos" },
        Answer = "Banana"
    };

    Question q3 = new Question
    {
        QuestionTitle = "Which evil master do the Minions serve?",
        Options = new List<string>() { "Gru", "Vector", "Scarlet Overkill", "Balthazar Bratt" },
        Answer = "Gru"
    };

    Question q4 = new Question
    {
        QuestionTitle = "What is the name of Gru's loyal scientist assistant?",
        Options = new List<string>() { "Dr. Nefario", "Professor Flux", "Dr. Evil", "Dr. Brain" },
        Answer = "Dr. Nefario"
    };

    Question q5 = new Question
    {
        QuestionTitle = "Which language do the Minions speak?",
        Options = new List<string>() { "Minionese", "Banana-speak", "Gibberish", "Minionish" },
        Answer = "Minionese"
    };

    Question q6 = new Question
    {
        QuestionTitle = "What is the name of the villain who steals the Moon in 'Despicable Me'?",
        Options = new List<string>() { "Vector", "El Macho", "Balthazar Bratt", "Scarlet Overkill" },
        Answer = "Vector"
    };

    Question q7 = new Question
    {
        QuestionTitle = "Who is the eldest Minion?",
        Options = new List<string>() { "Bob", "Kevin", "Stuart", "Dave" },
        Answer = "Stuart"
    };

    Question q8 = new Question
    {
        QuestionTitle = "What is the name of Gru's pet dog in 'Despicable Me'?",
        Options = new List<string>() { "Kyle", "Max", "Rex", "Buddy" },
        Answer = "Kyle"
    };

    Question q9 = new Question
    {
        QuestionTitle = "What is the name of the island where the Minions are banished in 'Minions'?",
        Options = new List<string>() { "Isle of Dogs", "Isle of Evil", "Isle of Misfits", "Isle of Mischief" },
        Answer = "Isle of Misfits"
    };

    Question q10 = new Question
    {
        QuestionTitle = "What is the name of the Minion who becomes king in 'Minions: The Rise of Gru'?",
        Options = new List<string>() { "Bob", "Kevin", "Stuart", "Otto" },
        Answer = "Bob"
    };

    Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 });
}


    }
}
