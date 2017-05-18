# unit-test-in-rider
simplest c# project with a unit test to illustrate issue [RIDER-6419](https://youtrack.jetbrains.com/issue/RIDER-6419)

## How to reproduce?
1. Open the `.sln` in Rider EAP-22
2. `Run All Tests` -> confirm the test is passing.
3. Edit `SomeClass.cs` so the return value on `line 7` is not `A`.
4. `Run All Tests`
    * The *EXPECTED* behavior is to see the test fail.
	* The *ACTUAL* behavior: the test stays green.
	
## Workaround
* If you do `Build -> Rebuild Solution` after editing the `SomeClass`, the test will fail (as expected)
