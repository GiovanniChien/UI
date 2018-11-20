// 作为《程序设计基础》的教师，王琼创作于2016-3-8。
#include <iostream>
using namespace std;

// 爱情是一场真情的戏，需要你唱我和
// 请注意男孩和女孩的函数结构存在必然的差异
// 男孩函数：在完成基本操作后，必须等待女孩的回应
// 女孩函数：有时候决定继续恋爱游戏，有时候决定婚姻殿堂
#define N 9
void BoyMissingGirl(int n);
void GirlMissingBoy(int n);

void main()
{   
	BoyMissingGirl(1); 
}

// 男孩的N次想念后，终于求婚
void BoyMissingGirl(int n)
{
	if(n<N)
		cout<<"Boy Missing Girl "<<n<<" times"<<endl;
	else
		cout<<"Boy: Let us togather"<<endl; // 男孩求婚
	GirlMissingBoy(n);      // 男孩必须等待女孩的回应
}
// 女孩的N次回应后，终于同意求婚
void GirlMissingBoy(int n)
{
	if(n<N)
	{
		cout<<"Girl Missing Boy "<<n<<" times"<<endl;
		BoyMissingGirl(n+1); // 女孩继续恋爱游戏：再想念我一次
	}
	else
		cout<<"Girl: We are togather"<<endl; // 女孩愿意
}

