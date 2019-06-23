
echo "Enter Folder Name to check"
read name

if [ -f $name ]
then
echo "Directory Exist"
else
echo "Doesn't Exist"
fi


