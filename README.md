# TestDomeTests

My answers to the public tests found here https://www.testdome.com/

Methods will be refactored, rewritten for modern .NET, packages will be updated and coding issues will be fixed.

---

## /AccountTest

https://www.testdome.com/questions/c-sharp/account-test/146077

TODO the deposit and withdraw methods deposit or withdraw the correct amounts

### Code smells / concerns

At the time of writing the code under test includes ```this.x``` statements where Visual Studio has been suggesting these should be removed for a long time?

**NUnit 3.12** was released in 2019, this code test seems out of date.

Deposits and withdrawls of zero are nonsensical.
