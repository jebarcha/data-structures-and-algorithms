# Data Structures

##Big-O Notation
We use **Big-O** notation to describe the performance of an algorithm
Measure the runtime complexity of an operation

### Linear Structures
* Arrays
* Linked List
* Stacks (LIFO, Pilas)
* Queues (FIFO, colas)
* Hash Tables

#### Arrays
Arrays in C# are static, it means has a fixed size
index starts with 0

####Linked List
We use Linked List to store a list of objects in sequence
but unlinke arrays, linked list can shrink and grow authomatically.

# Arrays vs Linked Lists
## SPACE
* Static arrays have a fixed size
* Dynamic arrays grow by 50-100%
* Linked list don't waste memory
* Use arrays is you know the number of items to store
* new ArrayList(100)

## Performance
Understand what problem you want to solve
				Arrays	Linked Lists
Lookup			O(1)	O(n)
				O(n)	O(n)
Insert	
  Beginning/End	O(n)	O(1)
  Middle		O(n)	O(n)
Delete  
  Beggining		O(n)	O(1)
  Middle		O(n)	O(n)
  End			O(n)	O(n)

# Types of Linked List
* SINGLY
* DOUBLY

