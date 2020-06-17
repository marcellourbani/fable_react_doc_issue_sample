# Fable documentation issue sample

Small example for misalignment between API and documentation

Created simply by running these commands:

```bash
dotnet new fable -n fable_react_doc_issue_sample
cd fable_react_doc_issue_sample
paket add nuget Fable.Elmish.React --project src/App.fsproj
```

and then copying the [sample code](https://elmish.github.io/react/browser.html)

Doesn't compile, so either the API needs a version bump or the documentation needs to be updated
Branch fixed contains the code adapted to the current API
