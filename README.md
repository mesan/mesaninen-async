# `async` og `await` for Mesaninen 2014

Here you will find the presentation, examples, exercises and solutions for the Mesanin course on `async` and `await`.

# Exercises

## Exercise 1: Non-blocking GUI

In this exercise, you will follow a step-by-step tour of async and await. Your task is to take a blocking GUI component
and make it non-blocking.

Start by checking out the starting step:

  git checkout starthere

### `step1`: Add a long-running method

The first version of the code is good enough when our button just does a very simple task that can never take long to
finish. This is important to keep in mind: `async` and `await` solve a problem, but are useless if that problem is not
present. Do not use them for simple tasks where asynchronicity is not required.

To make this a proper example, we need `DoWork()` to take a long time. Add a simple `Thread.Sleep(5000);` to make it
sleep for five second.

### `step2`: Make `startButton_Click()` into an `async` method

Let's take our first step on the road to asynchronicity. Add the `async`-keyword to `startButton_Click()`. What happens?

### `step3`: Make `DoWork()` awaitable

Next step is to convert `DoWork()` into an awaitable method. Go ahead and do that. This includes spawning a new thread
that performs the work in `DoWork()`.

Hint: What does an awaitable method have to return? (Three options.)

*Note:* Do *not* `await` the call to `DoWork()` yet. To retrieve the result string, the call should look like this:

  textBox.text = DoWork().Result;

Run the program. What happens now?

### `step4`: Async awaits!

Let's go all the way and make the code fully asynchronous. What do you have to do to accomplish that?
