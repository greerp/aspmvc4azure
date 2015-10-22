@echo off
echo Deploying files...
xcopy %DEPLOYMENT_SOURCE%\deploy\SimpleMvcWeb-001.zip %DEPLOYMENT_TEMP% /Y
echo Uncompressing files...
compact /u %DEPLOYMENT_TEMP%\SimpleMvcWeb-001.zip %DEPLOYMENT_TARGET%


