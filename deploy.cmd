@echo off
echo Extracting File System Deployment ...
unzip %DEPLOYMENT_SOURCE%\deploy\SimpleMvcWeb-001.zip -d %DEPLOYMENT_TARGET%
"d:\program files (x86)\Microsoft Sql Server\120\bin\DAC\bin\sqlpackage.exe" /action:import /tsn:pgsql015.database.windows.net /tdn:azuredb /tu:greepau /tp:R3dpixie /sf:%DEPLOYMENT_SOURCE\deploy\azuredb.bacpac




