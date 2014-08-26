# `async` and `await` for Mesaninen 2014

Here you will find the presentation, examples, exercises and solutions for the Mesanin course on `async` and `await`.

# Exercises

## Exercise 1: Non-blocking GUI

In this exercise, you will follow a step-by-step tour of async and await. Your task is to take a blocking GUI component
and make it non-blocking.

Start by checking out the starting step:

    git checkout starthere

Try running the program. What happens when you press the button? Can you use the textbox (or any other part of the GUI)?

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

(Hint: What does an awaitable method usually return?)

**Note:** Do *not* `await` the call to `DoWork()` yet. To retrieve the result string, the call should look like this:

    textBox.text = DoWork().Result;

Run the program. What happens now?

### `step4`: Async awaits!

Let's go all the way and make the code fully asynchronous. What do you have to do to accomplish that?

(Remember to change the string in `DoWork()` to `"Async and await rocks!"` :wink:)


### Exercise 1 in retrospect

In this exercise we learned that:

- You shouldn't necessarily use `async`/`await` for trivial operations. (There are some exceptions to this rule.)
- The `async` keyword by itself doesn't do anything.
- Without `async` and `await`, adding threads doesn't necessarily improve the program.
- Awaitable methods usually return `Task` or `Task<T>`.


## Exercise 2: Playing with Progress

:warning: &ensp; **Not done yet.**

## Exercise 3: Returning a value

## Exercise 4: `WhenAll`

Write a GUI program that loads four webpages in four `WebBrowser` components. When all the pages are done loading,
alert the user.

## Exercise 5: `WhenAny`

Write a console program that connects to four different websites, retrieves each page's HTML content and reports which
of them loads first.

## Exercise 6: Exception handling

:warning: &ensp; **Not done yet.**

## Exercise 7: `WebBrowserAsync`

Implement an `async` version of the `WebBrowser` component.

## Exercise 8: Cancellation

:warning: &ensp; **Not done yet.** -- Write a cancellable task.

