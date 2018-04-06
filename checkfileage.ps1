$returnStateOK = 0
$returnStateWarning = 1
$returnStateCritical = 2

//max age of the file
$date = (Get-Date).AddHours(-24)
$path = Path/to/folder

//get the latest file
$latest_file = Get-ChildItem $path | Sort-Object LastWriteTime -Descending | select -First 1

if ($latest_file.LastWriteTime -ge $date){
	Write-Host "OK - Latest file age" $latest_file.LastWriteTime
	exit $returnStateOK
}

else{
	Write-Host "Critical! - file" $latest_file "is too old"
	exit $returnStateCritical
}
