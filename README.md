# Read and parse a file; build a data structure to represent it and manipulate the data structure

## Input data
<Triangle>,1,2,3
<Rectangle>,4,2
<Square>,3
<Rectangle>,4,3
<Circle>,2
<End>

## Task
We would like you to write a program which can read a file like this into an appropriate data structure and then use the structures for some simple analysis of the data. 
1.	Design data structures to store this information. Design a class hierarchy, with an abstract ‘Area’ function in the base class.
2.	Write some code to read this file, parse the contents and populate the data structure you designed in stage 1.
3.	Then add functionality to calculate the total area of all the shapes that the program read from the file. 

## Notes
* This is an open test; feel free to ask questions at any stage; use the Internet as reference for anything you need to look up.
* In the time permitted, we don’t necessarily expect a fully functional working program, but to see what you *can* do.


## Supplemental Information - Area of a triangle
Given a triangle of sides (a,b,c)
set s=(a+b+c)/2
Then the area is sqrt(s(s-a)(s-b)(s-c))

