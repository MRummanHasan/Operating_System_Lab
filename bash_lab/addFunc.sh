func1()
{
local a='Result'
let c=$1+$2
echo $a $c
}

a='Hello '
echo $a
read inp1
read inp2
func1 $inp1 $inp2
