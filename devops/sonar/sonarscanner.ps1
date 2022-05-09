param (
[String] $project,
[String] $token
)

if (!$project) {
    Write-Output "You need to insert -project"
    exit
} 
if (!$token) {
    Write-Output "You need to insert -token"
    exit
}


# Run Sonar Scanner  
dotnet sonarscanner begin /k:"$project" /d:sonar.host.url="http://localhost:9001" /d:sonar.cs.vscoveragexml.reportsPaths=../../test/coverage.xml /d:sonar.coverage.exclusions="**/src/**/*.csproj,!**/test/**/*.Test.csproj" /d:sonar.login="$token"
dotnet coverage collect 'dotnet test ../../' -f xml  -o '../../test/coverage.xml'
dotnet build ../../
dotnet sonarscanner end /d:sonar.login="$token"

