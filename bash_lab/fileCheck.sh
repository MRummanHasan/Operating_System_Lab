#
# @author: M Rumman
# Program: 1) Check file exist or not. 2) Check File Type
# NOTE: Uncomment second program-code to use
# 

#!/bin/bash

echo "Enter Folder Name to check"
read name

if [ -f $name ]
then
echo "Directory Exist"
else
echo "Doesn't Exist"
fi


: '
let res=$1

if [ -d ${var}]
then
echo this is dir

elif [ -f ${var}]
then
echo this is file

else
echo other

fi
'
