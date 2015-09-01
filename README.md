# `async` and `await` for Mesaninen 2015

Here you will find the examples, exercises and solutions for the Mesanin course on `async` and `await`.

# Exercises

Notes about the exercises:

- Each exercise should be in its own project, unless specified otherwise.
- Feel free to pair program.
- If you are pair programming, you can program on one computer and checkout the suggested solutions on the other.

> :warning: &ensp; **Note:** Exercises 1 and 2 follow a very stepwise approach. Ask if you're not sure what the 
> exercise wants you to do, or `git checkout` the next step.


## Exercise 1: Non-blocking GUI

In this exercise, you will follow a step-by-step tour of async and await. Your task is to take a blocking GUI component
and make it non-blocking.

Start by checking out the starting step:

    git checkout starthere

Try running the program. What happens when you press the button? Can you use the textbox (or any other part of the GUI)?

### `starthere`: Add a long-running method

The first version of the code is good enough when our button just does a very simple task that can never take long to
finish. This is important to keep in mind: `async` and `await` solve a problem, but are useless if that problem is not
present. Do not use them for simple tasks where asynchronicity is not required.

To make this a proper example, we need `DoWork()` to take a long time. Add a simple `Thread.Sleep(5000);` to make it
sleep for five second.

### `ex1-step1`: Make `startButton_Click()` into an `async` method

Let's take our first step on the road to asynchronicity. Add the `async`-keyword to `startButton_Click()`. What happens?

### `ex1-step2`: Make `DoWork()` awaitable

Next step is to convert `DoWork()` into an awaitable method. Go ahead and do that. This includes spawning a new thread
that performs the work in `DoWork()`.

(Hint: What does an awaitable method usually return?)

**Note:** Do *not* `await` the call to `DoWork()` yet. To retrieve the result string, the call should look like this:

    textBox.text = DoWork().Result;

Run the program. What happens now?

### `ex1-step3`: Async awaits!

Let's go all the way and make the code fully asynchronous. What do you have to do to accomplish that?

(Remember to change the string in `DoWork()` to `"Async and await rocks!"` :wink:)

> :bulb: &ensp; **Tip:** Use `git checkout ex1-done` to see the full solution.

### Exercise 1 in retrospect

In this exercise we learned that:

- You shouldn't necessarily use `async`/`await` for trivial operations. (There are some exceptions to this rule.)
- The `async` keyword by itself doesn't do anything.
- Without `async` and `await`, adding threads doesn't necessarily improve the program.
- Awaitable methods usually return `Task` or `Task<T>`.


## Exercise 2: Playing with Progress

In this exercise we'll see how `async` makes a call non-blocking. Checkout `ex2-starthere` to get started.

    git checkout ex2-starthere

### `ex2-step1`: A simple progress tracker

In the initial code, there is no way to see the worker progression. Add a `ReportProgress()` method to `Program.cs`
that prints out a `.` every 100 ms as long as the worker is not complete. Do not add any calls to the function yet.

Hints:

- `Worker` has an `IsComplete` property.
- Use `Console.Write()` instead of `Console.WriteLine()` to print the periods on a single line.
- Remember `Thread.Sleep()`.

### `ex2-step2`: Using the progress tracker

What do you think will happen if you add a call to `ReportProgress()` after `worker.DoWork()`? Try it. Were you right?
What happened?

### `ex2-step3`: Progress tracker revisited 

Use what you learned in exercise 1, and make the `DoWork` method fully async. What happens with `ReportProgress()` now?

> :bulb: &ensp; **Tip:** Use `git checkout ex2-done` to see the full solution.


## Exercise 3: `Task.WhenAll`

Write a console program that loads four webpages and returns their length. When all the pages are done loading, alert the user and report which page is the longest.

> :bulb: &ensp; **Tip:** Use `HttpClient`.


## Exercise 4: `Task.WhenAny`

Write a console program that connects to four different websites, retrieves each page's HTML content and reports which
of them loads first.


## Exercise 5: Exception handling

TODO


## Exercise 6: Cancellation

Run through [the official tutorial](http://msdn.microsoft.com/en-us/library/jj155759.aspx) :grinning:

