// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>Argument completer implementation for ReplicationProtectedItemOperation.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ReplicationProtectedItemOperationTypeConverter))]
    public partial struct ReplicationProtectedItemOperation :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ReverseReplicate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ReverseReplicate", "ReverseReplicate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ReverseReplicate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Commit".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Commit", "Commit", global::System.Management.Automation.CompletionResultType.ParameterValue, "Commit");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PlannedFailover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PlannedFailover", "PlannedFailover", global::System.Management.Automation.CompletionResultType.ParameterValue, "PlannedFailover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UnplannedFailover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("UnplannedFailover", "UnplannedFailover", global::System.Management.Automation.CompletionResultType.ParameterValue, "UnplannedFailover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisableProtection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("DisableProtection", "DisableProtection", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisableProtection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TestFailover".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TestFailover", "TestFailover", global::System.Management.Automation.CompletionResultType.ParameterValue, "TestFailover");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TestFailoverCleanup".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TestFailoverCleanup", "TestFailoverCleanup", global::System.Management.Automation.CompletionResultType.ParameterValue, "TestFailoverCleanup");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failback".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("Failback", "Failback", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failback");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "FinalizeFailback".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("FinalizeFailback", "FinalizeFailback", global::System.Management.Automation.CompletionResultType.ParameterValue, "FinalizeFailback");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ChangePit".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ChangePit", "ChangePit", global::System.Management.Automation.CompletionResultType.ParameterValue, "ChangePit");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RepairReplication".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("RepairReplication", "RepairReplication", global::System.Management.Automation.CompletionResultType.ParameterValue, "RepairReplication");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SwitchProtection".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SwitchProtection", "SwitchProtection", global::System.Management.Automation.CompletionResultType.ParameterValue, "SwitchProtection");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CompleteMigration".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CompleteMigration", "CompleteMigration", global::System.Management.Automation.CompletionResultType.ParameterValue, "CompleteMigration");
            }
        }
    }
}