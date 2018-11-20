// 作为《程序设计基础》的教师，王琼创作于2016-3-8。
#include <iostream>
using namespace std;

#define N 9

// N次想念后，终于出口是“我们在一起”
void Missingyou(int n)
{
	if(n<=N)
	{
		cout<<"Missing you "<<n<<" times"<<endl;
		Missingyou(n+1);      // 再一次的想念
	}
	else
		cout<<"We are together"<<endl;
}

void main()
{
	Missingyou(1);
}

