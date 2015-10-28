#$bacpac = "F:\GitHub\aspmvc4azure\deploy\azuredb.bacpac"
$sqlpackage="C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120\sqlpackage.exe"
$cn = "Data Source=pgsql015.database.windows.net;Initial Catalog=aspmvc;User Id=greepau;Password=R3dpixie;"
$toks = $cn.split(";")

ForEach ($tok in $toks) { 
    $nv = $tok.split("=")

    switch ($nv[0].ToLower()){
        "data source" {$Server=$nv[1]}
        "initial catalog" {$Database=$nv[1]}
        "user id" {$User=$nv[1]}
        "password" {$password=$nv[1]}
    }
}

Write-Host "Server: ${Server}"
Write-Host "Database: ${Database}"
Write-Host "User: ${User}"
Write-Host "Password: ${password}"

#Write-Host "${sqlpackage}" "/Action:import" "/tsn:${server}" "/tdn:${database}" "/tu:${User} /tp:${password}" "/sf:${bacpac}"


#sqlpackage /Action:Export /ssn:LDNLT00099\SQLEXPRESS /sdn:azuredb /tf:c:\temp\sql\azuredb.bacpac

#C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\120>sqlpackage /action:import /tsn:pgsql015.database.windows.net /tdn:azuredb /tu:greepau /tp:R3dpixie /sf:F:\GitHub\aspmvc4azure\deploy\azuredb.bacpac




