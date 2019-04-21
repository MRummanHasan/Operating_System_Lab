#
# Array Initializing and Printing
#

arry=("One","Two","Three")

# print all array elements
echo ${arry[@]} 
echo ${arry[*]}

for i in ${arry[@]}
do
echo $i
done

# print with User Input
read end
for ((i=0;i<=$end;i++))
do
read a
arry[$i]=$a
done
