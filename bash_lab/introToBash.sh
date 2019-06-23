#! /bin/bash
: '
echo "Hello World"
echo "Enter Your Name"
read name
echo "Welcome Mr $name"
'

: '
read no1
read no2

((sum=$no1+$no2))
echo $sum

let c=$no1+$no2
echo $c
'

: '
echo "Enter Pwd"
read pass

if [[ $pass -eq 123 ]]
#if [[ $pass == "123" ]]
then
echo "Succesful Login"
else
echo "Invalid. Login failed !"
fi
'
: '
count=1
while [ $count -ne 10 ]
do
echo $count
((count++))
done
'
: '
for (( counter=0;counter<10;counter++ ))
do
echo "No: $counter"
done
'
: '
#Sending Argument to file
echo "No of Args $#"
echo "1 argv $1"
echo "2 argv $2"
echo "3 argv $3"
'
# Substring
str="This is OS Lab"
substr=${str:5:2}
echo $substr


