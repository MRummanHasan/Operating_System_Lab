
function sum()
{
((a=$1+$2))
echo $a
}
function sub()
{
((s=$1+$2))
echo $s
}
function mul()
{
((m=$1+$2))
echo $m
}
function div()
{
((d=$1+$2))
echo $d
}

sum 10 5
sub 10 5
mul 10 5
div 10 5


