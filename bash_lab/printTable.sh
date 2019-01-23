#!/bin/bash
read tab
read st
read en

for((i=1;i<$en;i++))
do
let res=$tab*$i

echo "$tab x $st = $res"

done

