IF NOT DEFINED Configuration SET Configuration=Release
MSBuild.exe PdfCompressorLibrary.sln -t:restore -p:RestorePackagesConfig=true
MSBuild.exe PdfCompressorLibrary.sln -m /property:Configuration=%Configuration%
git add -A
git commit -a --allow-empty-message -m ''
git push
