# Flashprint Converter
 Flashprint CGODE converter software for Little Monster

This is a converter tool I use for generating my GCODE files.  Originally, I used Slicer for all of my printing, however I found it too complicated and frustrating with often poor results.  However I had noticed that the flashprint tool used by one of our flashforge printers always had very nice looking prints with little effort required in the slicing.  After some investigation and failed attempts, I was able to convert the *.g output file (cannot use the *.gx, must be in the *.g output!) to something my printers recognize.

I currently have 3-4 printers in this software.  The basic conversion for all of them is the same, however I have unique start/stop code for each printer that gets appended.  SW could easily be modified to handle other printers with different start/stop gcode.

My two primary printers I use this on is the TEVO Little Monster and an ad-hoc printer that was originally a makerfarm printer that I built/modified/modified again.  NOTE: My TEVO Little Monster has been ported to MARLIN 2.0 Firmware and the Start/Stop code used reflects this (see my little monster marlin repository for more info).  There is another printer buried in the code which is one I built myself years ago, but never had much luck with, so it was mothballed.  However it was a dual extruder printer, so there is now some embedded support for dual printers if needed in the future.

#**INSTRUCTIONS**
1. Slice your project in Flashprint software.
2. Export a *.g file
3. Open the *.g file in the converter tool
4. Click "Analyze"
5. Select the correct printer, temps, speed, etc
6. Click "Fix Start/Stop Code"
7. Click "Save"
