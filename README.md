## Create Bluetooth Low Energy Application using C#
This is a sample script showing how to create Bluetooth Low Energy Application using C#
###  Requirments 
- [BlueIO](https://www.bleuio.com/index.php) 

For this script to work, a BleuIO dongle needs to be connected to the computer. Find the com port from windows device manager. 
In my computer, BleuIO is connected to 'com18'.
So the connected port should be update to 'com18' in form.cs

```        SerialPort mySerialPort = new SerialPort("COM18", 57600, Parity.None, 8, StopBits.One); ```


Get BleuIO at https://www.bleuio.com