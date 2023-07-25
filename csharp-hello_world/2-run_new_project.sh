#!/usr/bin/env bash
project="2-new_project"
mkdir "$project"
cd "$project"

dotnet new console
dotnet run