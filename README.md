# 一个基于树莓派的智能家居

## 配置环境
首先，先更新系统，保证环境为最新
```shell
sudo apt-get update
sudo apt-get upgrade
```
安装sqlite
```shell
sudo apt-get install sqlite
```

安装vlc，用作直播视频
```shell
sudo apt-get install vlc
```

安装wiringpi，用c语言控制GPIO
```shell
sudo apt-get install wiringpi
```

安装Pyhton开发环境，安装Flask框架，和RPIO
```shlell
sudo apt-get install python-dev
sudo apt-get install python-pip
sudo pip install flask

sudo apt-get install python-flask

sudo apt-get install python-setuptools
sudo easy_install -U RPIO
```

安装lirc——一个开源的红外控制的库
```shell
sudo apt-get install lirc
```
加载lir_rpi内核模块
```shell
sudo modprobe lirc_rpi gpio_in_pin=4 gpio_out_pin=5
```
