using System;
using System.Collections.Generic;

namespace QualitasDigitalSpecFlowCSharp.Extensions
{
    /// <summary>
    /// a log entry for a test step
    /// </summary>
    public static class TestStepLog
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<TestStep> TestSteps = new List<TestStep>();

        private static TimeSpan LastStepExecuted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stepDescription"></param>
        /// <param name="stepResult"></param>
        /// <param name="stepStatus"></param>
        /// <param name="time"></param>
        public static void GenerateTestStep(string stepDescription, string stepResult, string stepStatus, TimeSpan time)
        {
            TestStep testStep = new TestStep
            {
                StepDescription = stepDescription,
                StepResult = stepResult,
                StepStatus = stepStatus
            };

            if (LastStepExecuted == TimeSpan.MinValue)
            {
                testStep.Time = time;
            }
            else
            {
                testStep.Time = time - LastStepExecuted;
            }

            TestSteps.Add(testStep);
        }
    }
}
