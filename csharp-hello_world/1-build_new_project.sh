#!/usr/bin/env bash
project="1-new_project"
mkdir "$project"
cd "$project"

dotnet new console
dotnet build