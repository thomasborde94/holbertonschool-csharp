# Image Processing
## What is Multitasking ?
* Multitasking is the concept of running multiple applications at a time.
* Example: Windows operating system is a multitasking operating system.
* Each task can run independently and perform its specific job.
* Every application running is called a process (task manager in windows to see them).<br>
In C#, multi-tasking can be achieved using various techniques, including multi-threading and asynchronous programming.

## What is Threading ?
* A thread is the smallest unit of a CPU's execution, and it represents an independent sequence of instructions that can run concurrently with other threads.
* Threads within a process share the same memory space, which means they can access and modify the same data structures and variables. This shared memory allows for communication and synchronization between threads.
* Threading enables concurrent execution, which means that multiple threads can run simultaneously on multi-core processors. This concurrency can lead to improved performance and responsiveness in applications.
* A process has at least one thread which is commonly called as main thread, which actually executes the application code.
* A single process can have multiple threads.
* All the threading related classes are present in the `System.Threading` namespace.

### Multi-Threading vs. Multi-Processing
* Threading should not be confused with multi-processing, which involves running multiple independent processes (separate instances of the program) rather than multiple threads within a single process.
* Threads within a process share memory and are typically more lightweight and efficient than separate processes.<br>

## Thread Class Properties
* The Thread class helps us to perform tasks such as creating and setting the priority of a thread. We can use this class to controll a thread and obtain its status. The thread class provides various properties that allos to perform tasks such as obtaining the status of a thread or specifying a name for the thread.
* CurrentThread: retrieves the name of the thread which is currently running.
* IsAlive: retrieves a value to indicate the current state of thread execution. The value of IsAlive is true if the thread has been started or has been terminated, otherwise, the value is flase.
* Name: specifies a name for a thread.
* Priority: By default, has a value of Normal. We can assign either Highest, AboveNormal, Normal, BelowNormal or Lowest.

## Thread Class Methods
* Interrupt: interrupts the thread which is in the WaitSleepJoin state.
* Join: blocks a thread until another thread has terminated.
* Resume: resumes a thread which has been suspended earlier.
* Sleep: blocks the current thread for a specified time period.
* SpinWait: To make a thread wait the number of time specified in the parameters.
* Start: starts a thread
* Suspend: suspends a thread.

<br>
Documentation gathered with the help of [The DotNet Office youtube channel](https://www.youtube.com/@TheDotNetOffice).