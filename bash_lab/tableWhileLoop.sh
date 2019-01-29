echo Enter Table = 
read Table
echo Enter Table Start = 
read Start
echo Enter Table End = 
read End

while [ $Start -le $End ] #until [ $Start -ge $End]
do 

let res=$Table*$Start
echo $Table x $Start = $res
let Start++ #or ((start))

done
