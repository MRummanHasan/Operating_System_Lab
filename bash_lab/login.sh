#!/bin/bash
echo Enter Username: 
read name
echo Enter Password: 
read pwd
if [ $name=="name" ] && [ $pwd=="1234" ]
then
echo Succesful Login $name
else
echo Username and Password didnot match
fi



