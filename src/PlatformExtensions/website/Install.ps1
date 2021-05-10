param($installPath, $toolsPath, $package, $project)

Write-Output "Installpath $installPath"
Write-Output "Toolspath $toolsPath"
Write-Output "Package $package"

$projectFilePath = $project.FullName
Write-Output "ProjectFilePath $projectFilePath"

$projectDirectory = [System.IO.Path]::GetDirectoryName($projectFilePath)
Write-Output $projectDirectory

$razorViewFiles = Get-ChildItem -Path $projectDirectory -Filter "*.cshtml" -Recurse -File

Write-Output "Found $($razorViewFiles.Length) cshtml files"
foreach ($razorViewFile in $razorViewFiles)
{
    $razorViewFilePath = $razorViewFile.FullName
    $output = @()
    $lines = Get-Content -Path $razorViewFilePath
    [string]$oneliner = $lines
    if ($oneliner.Contains('@using Sitecore.Mvc.Analytics.Extensions'))
    {
        Write-Output "Processing file $($razorViewFilePath)"

        ## Add using
        foreach ($line in $lines) {
            $line = $line.Replace('@using Sitecore.Mvc.Analytics.Extensions', '@using AlexVanWolferen.PlatformExtensions.Extensions')
            $line = $line.Replace('@Html.Sitecore().VisitorIdentification()', '@Html.Sitecore().SafeVisitorIdentification()')
                
            $output += $line
        }
        
        $output | Set-Content -Path $razorViewFilePath
    }
}