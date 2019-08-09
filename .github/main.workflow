action "net-core" {
  uses = "joeltankam/dotnet-action@1.0.0"
}

workflow "Build" {
  on = "push"
  resolves = ["dotnet"]
}

action "dotnet" {
  uses = "actions/joeltankam/dotnet-action@1.0.0"
}
