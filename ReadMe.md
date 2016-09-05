# Advanced Programing 2016
## By Boris Ruiz Palma
### August 22nd, 2016
#### [The Slides for this course can be found here](https://docs.google.com/presentation/d/1E-2gj9hJMsxTLuwpwJ7g4hJY1O_hTjuw46iE4ttdK5s/edit#slide=id.g117415e531_0_24)

We used Markdown as an example of internal documentation and a proper way to 
describe our released features.

As an exercise for markdown I requested an example of tables using their
last semester´s grades as an example. _This are not my actual grades_ :p

| Date        | Subject           | Grade  |
| ------------- |-------------| -----:|
| 11/05/2009      | Software Engineering |  90 |
| 11/05/2009      | Financial Analysis |  85 |
| 11/05/2009      | Project Managment |  87 |

### August 24th, 2016
We started talking about the simple data structures. And Lists are the first example.
* We created an implementation using an array
* We created basic operations that are computationally expensive on purpose.
* Opertations Implemented
  * Initialize
  * InsertFirst
  * InsertLast
  * IsEmpty
  * FistElement
  * LastElement

### August 29th, 2016
We started by setting the constraints that are set in a Queue, basically **_FIFO (First In First Out)_** 
* We created an implementation using an array
* We created an implementation using an array
* We created basic operations that are computationally expensive on purpose.
  * Initialize  
  * Queue
  * Dequeue
  
### August 31st, 2016
We introduced the stack data structure, we analyzed how this structure contrasts with the Queue as it uses **_LIFO (List In First Out)_**

After presenting these 3 basic structures and implementing them using arrays the following exersices were presented.

Exercise # 1
Create the following instances. 
* 1 list of integers. (10 elements)
* 1 stack of integers. (10 elements)
* 1 queue of integers. (10 elements)

Add 10 random elements from 1 to 100 to the list.
Traverse the list from beggining to end, for each element greater than 50 add it to 
the stack, else add it to the queue.

Exercise # 2
Create the following instances. 
* 1 list of integers. (100 elements)
* 3 queues of integers. (100 elements)

Add 100 random elements from 1 to 100 to the list.
Traverse the list from beggining to end, for each element that is even add it to queue 1, 
for  each element that is a prime number add it to queue 2, for each element that is odd
add it to queue 3.

Ejercise # 3
Create the class Student with at least the following attributes.
* Name
* Study Program
* Semester he/she is currently studying.

Create the following instances. 
* 1 list of type Student. (10 elements)
* 2 queues of type Student.(10 elements)

According to a regular time table for URL student, traverse the list of students and 
add to queue 1 those whom attend during the morning and to queue 2 those who attend during
the evening.


