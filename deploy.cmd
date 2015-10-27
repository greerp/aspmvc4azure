@echo off
echo Extracting File System Deployment ...
echo "%DBSERVER% > %TEMP%\server1.txt
echo "%APPSETTING_DBSERVER% > %TEMP%\server2.txt
echo "%APPSETTING_DBSERVER% > %DEPLOYMENT_TARGET%\server3.txt
unzip %DEPLOYMENT_SOURCE%\deploy\SimpleMvcWeb-001.zip -d %DEPLOYMENT_TARGET%
"d:\program files (x86)\Microsoft Sql Server\120\DAC\bin\sqlpackage.exe" /action:import /tsn:%APPSETTING_DBSERVER%.database.windows.net /tdn:azuredb /tu:greepau /tp:R3dpixie /sf:%DEPLOYMENT_SOURCE\deploy\azuredb.bacpac




