	## Ballard ARINC 429 Custom Device ##

**Ballard ARINC-429 Custom Device** allows users to use the [Ballard ARINC 429 devices](http://www.ni.com/en-ca/shop/select/pxi-arinc-429-interface-module) inside NI VeriStand. This is an avionic interface bus standard. It's important to note that supported hardware are the "NI-Keyed boards only", product Part Number should have the form: “LV-222-###-###”. Only 441 and 442 core models are supported.


### LabVIEW Version ###

LabVIEW 2019 and later

### Built Availability ###

(In work) Builds available for VeriStand 2019 & 2020 under releases.

### Quality, Limitations ###

This IP is new. 

### Built Dependencies ###

[Astronics Ballard LabVIEW Driver 1.3.0.4 or Higher] https://www.ni.com/en-us/support/downloads/drivers/download.astronics-ballard-avionics-driver.html#343843
*tests on LinuxRT are done with 1.3.1 release [Updated 09/28/2020]

### Source Dependencies ###

[Astronics Ballard LabVIEW Driver 1.3.0.4 or Higher] https://www.ni.com/en-us/support/downloads/drivers/download.astronics-ballard-avionics-driver.html#343843

[OpenG Array Library 4.1.1.14 or Higher] vipm://oglib_array?repo_url=http://www.jkisoft.com/packages

[OpenG MD5 Digest Library 4.1.1.10 or Higher] vipm://oglib_md5?repo_url=http://www.jkisoft.com/packages

[VeriStand Custom Device Development Tools 20.3.0 or Higher] https://github.com/ni/niveristand-custom-device-development-tools/releases

Code uses 2 .NET Assemblies compiled into DLLs. The source code is available here:
- Hardware XML File: https://github.com/NIVeriStandAdd-Ons/Ballard-Arinc-429-Custom-Device/tree/master/Source/Assemblies/HW%20XML%20File/
- Parameters XML File: https://github.com/NIVeriStandAdd-Ons/Ballard-Arinc-429-Custom-Device/tree/master/Source/Assemblies/Parameters%20XML%20File


### License ###

*This repository and any materials provided by NI therein are provided AS IS. NI DISCLAIMS ANY AND ALL LIABILITIES FOR AND MAKES NO WARRANTIES, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR  PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF INTELLECTUAL PROPERTY. NI shall have no liability for any direct, indirect, incidental, punitive, special, or consequential damages for your use of the repository or any materials contained therein.*
