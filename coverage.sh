#!/bin/bash
# Just run ./coverage.sh
# Files are available in reports/ folder (Not that they are excluded in VS Code. You can change this in .vscode/settings.json)

dotnet test /p:CollectCoverage=true /p:CoverletOutput=../reports/coverage/ /p:MergeWith="../reports/coverage/coverage.json" /p:CoverletOutputFormat=\"opencover,json\" -m:1
