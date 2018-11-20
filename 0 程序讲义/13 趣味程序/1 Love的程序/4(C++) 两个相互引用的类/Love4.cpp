// 作为《面向对象的程序设计方法》的教师，王琼创作于2016-3-8。
#include <iostream>
using namespace std;

#define N 9
// 看懂这个程序，面向对象的程序设计方法，已经入门了
// 由于类之间相互的引用关系，类的定义显得有些繁琐。但体现了程序员对编译技术的理解
class clsGirl;   // 女孩类必须前向说明，因为男孩的Missing中有她
class clsBoy
{
public:
	void MissingGirl(clsGirl &Girl, int n);
};

class clsGirl
{
public:
	void MissingBoy(clsBoy &Boy, int n);
};

// 男孩的N次想念Girl后，终于求婚
void clsBoy::MissingGirl(clsGirl &Girl, int n)
{
	if(n<N)
		cout<<"Boy Missing Girl "<<n<<" times"<<endl;
	else
		cout<<"Boy: Let us togather"<<endl; // 男孩求婚
	Girl.MissingBoy(*this, n);      // 男孩必须等待女孩的回应
}

// 女孩的N次回应后，终于同意求婚
void clsGirl::MissingBoy(clsBoy &Boy, int n)
{
	if(n<N)
	{
		cout<<"Girl Missing Boy "<<n<<" times"<<endl;
		Boy.MissingGirl(*this, n+1); // 女孩继续恋爱游戏：再想念我一次
	}
	else
		cout<<"Girl: We are togather"<<endl; // 女孩愿意
}

void main()
{
    clsBoy Boy;  clsGirl Girl;  // 一个男孩和一个女孩的世界
	Boy.MissingGirl(Girl, 1);   // 由男孩开始的恋情
	Girl.MissingBoy(Boy, 1);    // 由女孩开始的恋情
}