read -p "Enter an integer : " num
if [[ $num -lt 0 ]]; then
	echo "Number is negative. "
elif [[ $num -gt 0 ]]; then
	echo "Number is positive. "
else echo "Number is equal to zero. "
fi
