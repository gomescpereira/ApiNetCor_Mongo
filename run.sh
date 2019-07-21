mkdir TestResults
dotnet test --logger:trx --results-directory ./TestResults
pgrep chrome | xargs kill -9