ShadowsocksR for Windows
=======================


## Build

[![](https://github.com/HMBSbige/ShadowsocksR-Windows/workflows/CI/badge.svg)](https://github.com/HMBSbige/ShadowsocksR-Windows/actions)

## [Wiki](https://github.com/HMBSbige/ShadowsocksR-Windows/wiki)

## Download

* [latest release]

## Develop

Visual Studio Community 2022 is recommended.

## License

GPLv3

Copyright © 2019 - 2022 HMBSbige. Forked from ShadowsocksR by BreakWa11

[latest release]: https://github.com/HMBSbige/ShadowsocksR-Windows/releases

## FAQ
**Q1** ARSoft.Tools.Net.Dns包相关
```
# 报错
CS0246  未能找到类型或命名空间名“DnsOverTlsClient”(是否缺少 using 指令或程序集引用?)    shadowsocksr    E:\Github_repository\ShadowsocksR-Windows\shadowsocks-csharp\Model\DnsClient.cs 234 

# 原因
1.ARSoft.Tools.Net.Dns包版本兼容问题
2.使用ARSoft.Tools.Net.Dns-2.3.1版本

# 解决
1.官网手动下载ARSoft.Tools.Net.Dns 2.3.1版本包：
	https://www.nuget.org/packages
2.拷贝到软件包本地源：
	cp arsoft.tools.net.dns.2.3.1.nupkg 'C:\Program Files (x86)\Microsoft SDKs\NuGetPackages'
3.安装
	vs2022 -> nuget包管理器 -> 选择本地源 -> 安装arsoft.tools.net.dns
```

**Q2** donet与vs版本问题
```
# 报错
在win11 vs2022环境下"shadowsocksr.csproj"文件使用"<TargetFramework>net7.0-windows</TargetFramework>"配置,
报错vs2022不在支持donet 7.0 runtime

# 原因
1.win10 + vs2017/vs2022 对应 donet 7.0
2.win11 + vs2022 对应 donet 9.0

# 解决
1.win10 + vs2022:
	vim shadowsocksr.csproj:
		<TargetFramework>net7.0-windows</TargetFramework>
1.win11 + vs2022:
	vim shadowsocksr.csproj:
		<TargetFramework>net9.0-windows</TargetFramework>
```
