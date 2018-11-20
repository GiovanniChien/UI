// 作为《程序设计基础》的教师，王琼创作于2016-3-8。
#include <iostream>
using namespace std;

// 他(她)已经发觉自己纠结的内心了，但递归没有出口，所以有无数次的想念
void Missingyou()
{
	cout<<"Missing you"<<endl;
	Missingyou();
}

void main()
{
	Missingyou();
}
