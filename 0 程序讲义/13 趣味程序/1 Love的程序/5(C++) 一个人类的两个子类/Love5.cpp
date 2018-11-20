// 作为《面向对象的程序设计方法》的教师，王琼创作于2016-3-8。
#include <iostream>
using namespace std;

#define N 9
// 看懂这个程序，面向对象的程序设计方法，可以出师了
// 引入了年轻人类作为男孩类和女孩类的共性，简化了程序结构
class clsYoung   // 年轻人类
{
public:
	// 只要还有青春，就有思念
	void virtual Missing(clsYoung &Young, int n)=0;
};

class clsBoy: public clsYoung  // 男孩是一种年轻人
{
public:
	// 男孩的N次想念Girl后，终于求婚
	void virtual Missing(clsYoung &Girl, int n)
	{
		if(n<N)
			cout<<"Boy Missing Girl "<<n<<" times"<<endl;
		else
			cout<<"Boy: Let us togather"<<endl; // 男孩求婚
		Girl.Missing(*this, n);      // 男孩必须等待女孩的回应
	}
};

class clsGirl: public clsYoung  // 女孩是一种年轻人
{
public:
	// 女孩的N次回应后，终于同意求婚
	void virtual Missing(clsYoung &Boy, int n)
	{
		if(n<N)
		{
			cout<<"Girl Missing Boy "<<n<<" times"<<endl;
			Boy.Missing(*this, n+1); // 女孩继续恋爱游戏：再想念我一次
		}
		else
			cout<<"Girl: We are togather"<<endl; // 女孩愿意
	}
};

void main()
{
    clsBoy Boy;	clsGirl Girl;  // 一个男孩和一个女孩的世界
	Boy.Missing(Girl, 1);      // 由男孩开始的恋情
	Girl.Missing(Boy, 1);      // 由女孩开始的恋情
}