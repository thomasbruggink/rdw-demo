$subnet = "10.0.0.0/16"

Stop-Service docker
Get-ContainerNetwork | Remove-ContainerNetwork -Force
$daemonFile = "C:\ProgramData\Docker\config\daemon.json"
if(Test-Path "C:\ProgramData\Docker\config\daemon.json")
{
    Remove-Item $daemonFile
}
$noBridgeContent = "{ `"bridge`" : `"none`" }"
$noBridgeContent | Set-Content $daemonFile
New-ContainerNetwork -Name "demo-nat" -Mode NAT -SubnetPrefix $subnet -GatewayAddress 10.0.0.1
Start-Service docker

New-NetFirewallRule -Name "Local Docker" -DisplayName "Local Docker" -RemoteAddress $subnet -LocalAddress $subnet