$acl = Get-Acl "F:/Suli/DontRot/DontRot.Api/bin/Release/netcoreapp2.2/publish"
$aclRuleArgs = "somi-fx8350\somi", "Read,Write,ReadAndExecute", "ContainerInherit,ObjectInherit", "None", "Allow"
$accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule($aclRuleArgs)
$acl.SetAccessRule($accessRule)
$acl | Set-Acl "F:/Suli/DontRot/DontRot.Api/bin/Release/netcoreapp2.2/publish"

New-Service -Name DontRotApi -BinaryPathName "F:/Suli/DontRot/DontRot.Api/bin/Release/netcoreapp2.2/publish/DontRot.Api.exe" -Credential "somi-fx8350\somi" -Description "DontRotApi" -DisplayName "DontRotApi" -StartupType Automatic