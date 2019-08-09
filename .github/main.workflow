workflow "Restore, Build, Test" {
  on = "push"
  resolves = ["Test"]
}

action "Restore" {
  uses = "joeltankam/dotnet-action@master"
  args = "restore --verbosity minimal"
}

action "Build" {
  needs = "Restore"
  uses = "joeltankam/dotnet-action@master"
  args = "build --configuration Release"
}

action "Test" {
  needs = "Build"
  uses = "joeltankam/dotnet-action@master"
  args = "test --logger:trx"
}
