mkdir TestResults
dotnet test --logger:trx --result-directory ./TestResults
pgrep chrome | xargs kill -9