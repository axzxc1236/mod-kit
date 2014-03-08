@echo off
cd mod-kit
7za d tmp.jar META-INF\*
7za x mod.zip -otmp
7za a tmp.jar .\tmp\*