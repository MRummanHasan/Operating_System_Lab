#
#
#
#

#!/bin/bash
mkdir A
cd A
for((i=0;i<1000;i++))
do
touch $i
done
cd ..

mkdir B
cd B
for((i=0;i<1000;i++))
do
touch $i
done
cd ..
