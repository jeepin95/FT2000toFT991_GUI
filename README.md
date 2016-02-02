# FT2000toFT991_GUI
This application is intended to intercept and modify the frequency setting commands from RMS Express in order to
properly set the frequency on the Yaesu FT-991. This is only a temporary solution until RMS Express is able to 
support the FT-991 directly.

This application assumes that a dual serial port, null modem cable is available for the intercepted communications.
This can be accomplished with a tool like com0com configured with dual virtual serial ports and a virtual
null modem adapter.

Example Setup:

FT-991 Enhanced Serial Port: COM1 -> Select COM1 under the FT-991 settings in FT2000toFT991
FT-991 Standard Serial Port: COM2 -> IGNORED
com0com virtual port 1: COM3 -> Select COM3 in RMS Express for the rig control port, radio type FT-2000
com0com virtual port 2: COM4 -> Select COM4 in FT2000toFT991 settings for the RMS Express port

FT2000toFT991 will read all commands sent by RMS Express to the radio. When the "FA" command is detected which
attempts to set the frequency on an FT-2000 the command will be modified to match the FT-991 protocal and forwarded
on to the FT-991. In addition the "FB" command will also be sent to set VFO-B to the same frequency which appears
to work much better with the internal tuner on the FT-991. 

RMS Express does not use the CAT PTT commands so PTT will need to be accomplished via other means, either with
RS232 keying or VOX.

