#include "SampleClass.h"

// Addition
extern "C" _declspec(dllexport) int Add(int value1, int value2)
{
	int result;
	_asm
	{
			mov eax, value1
			add eax, value2
			mov result, eax
	}
	return result;
}
//Substraction
extern "C" _declspec(dllexport) int Sub(int value1, int value2)
{
	int result;
	_asm
	{
			mov eax, value1
			sub eax, value2
			mov result, eax
	}
	return result;
}

extern "C" _declspec(dllexport) int Mul(int value1, int value2)
{
	int result;
	_asm
	{
			mov eax, value1
			mov ebx, value2
			imul ebx
			mov result, eax
	}
	return result;
}
extern "C" _declspec(dllexport) int Div(int value1, int value2)
{
	int result;
	_asm
	{
			mov eax, value1
			mov ebx, value2
			idiv ebx
			mov result, eax
	}
	return result;
}

extern "C" _declspec(dllexport) int Sqaure(int value1)
{
	int result;
	_asm
	{
			mov eax, value1
			imul value1
			mov result, eax
	}
	return result;
}

extern "C" _declspec(dllexport) int Cube(int value1)
{
	int result=0;
	_asm
	{
			mov eax, value1
			imul value1
			imul value1
			mov result, eax
	}
	return result;
}