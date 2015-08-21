# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 

##Pureewat Kruatong 570611031##

## Revision, put your commit number here
* Sort from larger to smaller: 2524b333 
* Without flag: 2d30ee01

## Questions
1. How this code can sort number from smaller to larger
 
Answer: Compare between two number and check until last pair of number and check again until all number is sorted.

2. What if two numbers equal, what will happen? 

Answer: The 'if' condition[line 24] is false, when condition false it will skip this condition and go to check next number.  

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: 27 times.

4. Why we need flag variable ? 

Answer: Use to check that input is sorted.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Program will run faster because when we remove flag we should remove while loop, So it will decrease time to progress
		when while loop is removed.