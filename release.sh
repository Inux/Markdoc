#!/bin/bash
# Usage: ./release.sh nuget_api_key

source env.sh

PACK_DIR="bin/Debug"
NUGET_URL="https://api.nuget.org/v3/index.json"

#Core
(cd Markdoc.Core/src && 
    rm -f $PACK_DIR/*.nupkg &&
    dotnet pack && 
    dotnet nuget push "$PACK_DIR"/Markdoc.Core.0.0.3.nupkg -k $1 -s $NUGET_URL)

#Components
(cd Markdoc.Components/src &&
    rm -f $PACK_DIR/*.nupkg &&
    dotnet pack &&
    dotnet nuget push "$PACK_DIR"/Markdoc.Components.0.0.3.nupkg -k $1 -s $NUGET_URL)

exit $?
