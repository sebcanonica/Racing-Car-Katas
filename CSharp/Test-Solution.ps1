# Build Solution
$path = & "${Env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere" -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
if (! $path) {
    Throw "Could not locate vswhere"
}
Write-Host $path
$path = join-path $path 'MSBuild\Current\Bin\MSBuild.exe'
if (! (test-path $path) ) {
    Throw "Could not locate MSBuild"
}
& $path .\TDDMicroExercises.sln

if( $LastExitCode -ne 0) {
} else {
    # Run tests
    .\packages\xunit.runner.console.2.4.1\tools\net461\xunit.console.exe .\bin\Debug\TDDMicroExercises.dll
}