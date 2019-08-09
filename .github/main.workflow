workflow "Build" {
  resolves = [
    "Setup Dotnet for use with actions",
    "net-core",
  ]
  on = "push"
}

action "net-core" {
  uses = "joeltankam/dotnet-action@1.0.0"
}
