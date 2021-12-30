# 项目描述
+ 本项目根据巴基斯坦计算机与新兴科学国立大学的AKHTAR JAMIL(阿赫塔尔.贾米尔)的Emgu CV教程编写。由于开发环境的差异做了相应调整。
+ 源连接：[Emgucv # 19: Real-time text Detection from Videos in Emgu CV - YouTube](https://www.youtube.com/embed/?list=PLUSwCY_ybvyLcNxZ1Q3vCkaCH9rjrRxA6)


# 参考引用
2021-12-24 图像处理中常见的形态学方法 - 知乎 https://zhuanlan.zhihu.com/p/110787009
2021-12-24 WinForm数据绑定-简单绑定1 - 蔡鹏 - 博客园 https://www.cnblogs.com/travelcai/archive/2008/06/15/1222525.html
2021-12-24 C# ValueTuple（值元组） - C#教程 - 菜鸟教程 https://www.cainiaojc.com/csharp/csharp-valuetuple.html
2021-12-24 VS2022禁用全局using，禁用GlobalUsings.g.cs - yhuse - 博客园 https://www.cnblogs.com/yhuse/p/GlobalUsings.html
2021-12-24 【实战】C# 10 新语法 global using 全局引用_.Net/C#_架构师_程序员_码农网 https://www.itsvse.com/thread-10162-1-1.html


# 教程和讲义

# p13 形态学操作
+ 1.Erosion(腐蚀)
+ 2.Dilation(膨胀)
+ 3.Opening(开运算)
+ 4.Closing(闭运算)
+ 5.Gradient(梯度)
+ 6.Top Hat(白色顶帽变换)
+ 7.Black Hat(黑色顶帽变换)

# p22 如何安装EmguCV 3.3
(略过)


# p25-26
+ (这两个是一体的)
+ 数据来源：https://www.kaggle.com/c/digit-recognizer/data


# p28
## 对象
+ 人脸检测
  + - Haar级联分类器
  + - LBP级联分类器

+ 数据集
  + -OpenCV提供的XML文件
    + 接受过各种面部和非面部训练
    + 可以从静态图像、视频和实时录像中检测面部

# p29
## 对象
+ 形状检测
  + - 查找轮廓
  + - 几何约束

+ 参考
  + -https://www.pyimagesearch.com/2016/02/08/opencv-shape-detection/

# p30
## 对象
+ 连接组件标签
+ 用鼠标获取单个对象

# p32 带统计信息的连接组件标记/Connected Component Labeling with Statistics
+ 获取对象并显示其统计信息
```
public static int ConnectedComponentsWithStats(
	IInputArray image,
	IOutputArray labels,
	IOutputArray stats,
	IOutputArray centroids,
	LineType connectivity = LineType.EightConnected,
	DepthType labelType = DepthType.Cv32S,
	ConnectedComponentsAlgorithmsTypes cclType = ConnectedComponentsAlgorithmsTypes.Default
)
```

# p33 使用Nuget包管理器安装EmguCV 4.x
(略过)

# p38 基于特征的图像匹配
## 特征检测，描述和匹配