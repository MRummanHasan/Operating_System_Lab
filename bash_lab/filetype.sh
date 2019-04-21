#!/bin/bash

let res=$1

if [ -d ${var}]
then
echo this is dir

elif [ -f ${var}]
then
echo this is file

else
echo other

fi
