while($true) 
{
     Sleep 3600; 
} 
Write-Error 'Process stopped'; 
Get-EventLog System -Newest 50 | select *