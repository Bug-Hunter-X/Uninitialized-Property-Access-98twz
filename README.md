# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties can lead to unexpected behavior and exceptions, particularly in scenarios where the property is used in calculations or comparisons before it's explicitly set.

The `bug.cs` file shows a method that attempts to use an uninitialized property, potentially causing a `NullReferenceException` or other runtime errors. The `bugSolution.cs` file provides corrected code, highlighting best practices to avoid this problem.

## How to Reproduce

1. Clone the repository.
2. Compile and run `bug.cs`.
3. Observe the exception or unexpected result.
4. Compare to the corrected code in `bugSolution.cs`.