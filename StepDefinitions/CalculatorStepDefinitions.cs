using NUnit.Framework;

namespace ReqnrollCalculator.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
           _calculator.FirstNumber = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Addition();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtraction();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiplication();
           
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Division();
        }


        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, _result);
        }
    }
}
