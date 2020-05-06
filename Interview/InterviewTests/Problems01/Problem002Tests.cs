using Interview.Problems01;
using NUnit.Framework;

namespace InterviewTests.Problems01
{
    [TestFixture]
    public class Problem002Tests
    {
        private class Command
        {
            public readonly int ExpectedMin;

            public readonly int ExpectedStackTop;

            public readonly string Operation;

            public readonly int Value;

            public Command(string operation, int value, int stackTop, int min)
            {
                Operation = operation;
                Value = value;
                ExpectedStackTop = stackTop;
                ExpectedMin = min;
            }
        }

        [Test]
        public void SolveTest()
        {
            var commands = new[]
            {
                new Command("push", 3, 3, 3),
                new Command("push", 4, 4, 3),
                new Command("push", 2, 2, 2),
                new Command("push", 1, 1, 1),
                new Command("pop", -1, 2, 2),
                new Command("pop", -1, 4, 3),
                new Command("push", 0, 0, 0)
            };

            var stack = new Problem002.StackWithMin<int>();

            foreach (var command in commands)
            {
                if (command.Operation == "push")
                    stack.Push(command.Value);
                else if (command.Operation == "pop")
                    stack.Pop();

                Assert.AreEqual(command.ExpectedStackTop, stack.Peek());
                Assert.AreEqual(command.ExpectedMin, stack.Min());
            }
        }
    }
}
