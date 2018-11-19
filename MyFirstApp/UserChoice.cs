using FluentValidation;
using System.Collections.Generic;

namespace RockPaperScissors {

    class UserChoice {
        public string choice;

        public UserChoice(string choice) {
            this.choice = choice;
        }
    }

    class YesNoValidator : AbstractValidator<UserChoice>{

        public YesNoValidator() {
            RuleFor(x => x.choice).Must(BeAValidYesOrNoAnswer);
        }

        private bool BeAValidYesOrNoAnswer(string choice) {
            var yesOrNoAnswers = new List<string> { "Yes", "No", "Y", "N" };
            return yesOrNoAnswers.Contains(choice);
        }
    }
}
