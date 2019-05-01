$returnStateOK = 0
$returnStateWarning = 1
$returnStateCritical = 2
$path=""
$items = (Get-ChildItem $path | measure).Count

if ($items -le 100){
    write-host "OK - $items in queue"
    exit $returnStateOK
}

elseif ($items -gt 100 -and $items -le 150){
    Write-Host "Warning - $items in queue"
    exit $returnStateWarning
}

else{
    Write-Host "Critical! - $items in queue"
    exit $returnStateCritical
}
