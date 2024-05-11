using Microsoft.AspNetCore.Components;
using Quizzing.Models;

namespace Quizzing.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
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
            questionIndex++;
        }

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex = 0;
        }

        private void LoadQuestions()
{
    Question q1 = new Question
    {
        QuestionTitle = "What is the capital city of France?",
        Options = new List<string>() { "Paris", "London", "Rome", "Berlin" },
        Answer = "Paris"
    };

    Question q2 = new Question
    {
        QuestionTitle = "Who wrote the play 'Romeo and Juliet'?",
        Options = new List<string>() { "William Shakespeare", "Jane Austen", "Charles Dickens", "Emily Brontë" },
        Answer = "William Shakespeare"
    };

    Question q3 = new Question
    {
        QuestionTitle = "Which planet is known as the 'Red Planet'?",
        Options = new List<string>() { "Jupiter", "Mars", "Venus", "Saturn" },
        Answer = "Mars"
    };

    Question q4 = new Question
    {
        QuestionTitle = "Who painted the famous artwork 'Mona Lisa'?",
        Options = new List<string>() { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Michelangelo" },
        Answer = "Leonardo da Vinci"
    };

    Question q5 = new Question
    {
        QuestionTitle = "What is the chemical symbol for water?",
        Options = new List<string>() { "H2O", "CO2", "NaCl", "O2" },
        Answer = "H2O"
    };

    Question q6 = new Question
    {
        QuestionTitle = "Who wrote the novel 'Pride and Prejudice'?",
        Options = new List<string>() { "Jane Austen", "Charlotte Brontë", "Emily Dickinson", "George Eliot" },
        Answer = "Jane Austen"
    };

    Question q7 = new Question
    {
        QuestionTitle = "What is the tallest mountain in the world?",
        Options = new List<string>() { "Mount Kilimanjaro", "Mount Everest", "Mount Fuji", "Mount McKinley" },
        Answer = "Mount Everest"
    };

    Question q8 = new Question
    {
        QuestionTitle = "Which continent is the largest by land area?",
        Options = new List<string>() { "Asia", "Africa", "North America", "Europe" },
        Answer = "Asia"
    };

    Question q9 = new Question
    {
        QuestionTitle = "Who invented the telephone?",
        Options = new List<string>() { "Thomas Edison", "Alexander Graham Bell", "Nikola Tesla", "Albert Einstein" },
        Answer = "Alexander Graham Bell"
    };

    Question q10 = new Question
    {
        QuestionTitle = "What is the chemical symbol for gold?",
        Options = new List<string>() { "Au", "Ag", "Fe", "Pb" },
        Answer = "Au"
    };

    Questions.AddRange(new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10 });
}

    }
}
