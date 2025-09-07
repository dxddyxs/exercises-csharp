# Run all projects in order (alguns projetos pedem input manual)
$projects = Get-ChildItem -Directory | Where-Object { $_.Name -like "Ex*" } | Sort-Object Name | ForEach-Object { $_.Name }
foreach ($p in $projects) {
    Write-Host "`n---- Running $p ----"
    dotnet run --project $p
}
