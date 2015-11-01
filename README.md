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
配置树莓派的lirc，需要在`/boot/config.txt`中添加
```
dtoverlay=lirc-rpi,gpio_out_pin=24,gpio_in_pin=23
```
配置这个时，从别的博客都不靠谱，不过最终我在[这里](https://github.com/raspberrypi/firmware/blob/master/boot/overlays/README)，找到了官方给的方法，lirc默认的输出引脚是GPIO17，默认的输入引脚是GPIO13，不过可以在`config.txt`中自己更改，然后重启就可以了。

加载lir_rpi内核模块
```shell
sudo modprobe lirc_rpi
```
测试
```shell
sudo mode2 -d /dev/lirc0
```
现在就会看到一大串space和pulse交替产生。

配置`/etc/lirc/hardware.conf`
```config
# /etc/lirc/hardware.conf
#
# Arguments which will be used when launching lircd
LIRCD_ARGS="--uinput"

#Don't start lircmd even if there seems to be a good config file
#START_LIRCMD=false

#Don't start irexec, even if a good config file seems to exist.
#START_IREXEC=false

#Try to load appropriate kernel modules
LOAD_MODULES=true

# Run "lircd --driver=help" for a list of supported drivers.
DRIVER="default"
# usually /dev/lirc0 is the correct setting for systems using udev
DEVICE="/dev/lirc0"
MODULES="lirc_rpi"

# Default configuration files for your hardware if any
LIRCD_CONF=""
LIRCMD_CONF=""
```