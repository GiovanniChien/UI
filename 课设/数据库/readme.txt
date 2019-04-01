MySql数据库使用前需要先导入MySql.Data.dll
（注：压缩包中的dll只适用mysql8.0以上，若mysql版本低于8.0可到mysql官网中下载对应版本的.NET驱动）

步骤：
1.将dll拷贝到项目的bin目录下
2.选择右侧项目资源管理器中的引用，右击，选择添加引用->浏览->导入dll文件
3.使用mysql相关api时使用using MySql.Data.MySqlClient;引入改名空间。