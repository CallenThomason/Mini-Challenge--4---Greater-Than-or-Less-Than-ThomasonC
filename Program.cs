/*
Callen Thomason
Mini Challenge #4 - Greater Than or Less Than
9/9/2026
I used if statements to determine if two user inputs where equal to, greater than, or less than each other. 
Used ReadLine to collect user inputs as strings and Convert.ToInt32() to turn the strings into integers. 
Peer Review name: 
Review: 
include a png of flowchart 

*/


Console.Clear(); 
Console.Write("Enter a number: "); 
String num1 = Console.ReadLine(); 
Console.Write("Enter another number: "); 
String num2 = Console.ReadLine(); 
int realNum1 = Convert.ToInt32(num1); 
int realNum2 = Convert.ToInt32(num2); 
if(realNum1 == realNum2) //checks if they are equal
{
   Console.WriteLine($"{realNum1} is equal to {realNum2}"); 
   
    Console.WriteLine($"{realNum2} is equal to {realNum1}"); 
}//end if
else if(realNum1 > realNum2) //checks if the first one is greater than the second
{
    Console.WriteLine($"{realNum1} is greater than  {realNum2}"); 

    Console.WriteLine($"{realNum2} is less than  {realNum1}"); 
} //end else if
else //runs if both are not true
{
    Console.WriteLine($"{realNum1} is less than  {realNum2}"); 

    Console.WriteLine($"{realNum2} is greater than  {realNum1}"); 
} //end else