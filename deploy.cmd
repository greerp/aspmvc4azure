@echo off
echo Deploying files...
rem xcopy %DEPLOYMENT_SOURCE%\deploy\SimpleMvcWeb-001.zip %DEPLOYMENT_TEMP% /Y
echo Uncompressing files...
rem compact /u %DEPLOYMENT_TEMP%\SimpleMvcWeb-001.zip %DEPLOYMENT_TARGET%

unzip %DEPLOYMENT_SOURCE%\deploy\SimpleMvcWeb-001.zip -d %DEPLOYMENT_TARGET%



