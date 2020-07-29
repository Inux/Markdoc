#!/bin/bash

source env.sh

dotnet publish -c Release $API
dotnet publish -c Release $CLIENT

exit $?
