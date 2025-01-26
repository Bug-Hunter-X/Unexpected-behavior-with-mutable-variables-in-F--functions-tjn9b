# F# Mutable Variable Behavior in Functions

This example demonstrates an uncommon error related to how mutable variables behave within F# functions.  In F#, values are passed by value (copied), not by reference. This means that changes made to mutable variables *inside* a function don't affect the original variables *outside* the function unless you explicitly pass references (e.g., using ref cells).

The `bug.fs` file shows the erroneous code. The `bugSolution.fs` file provides a corrected version illustrating how to achieve the desired behavior using `ref` cells if necessary.