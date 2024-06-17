# About

MMARAttributes is a unity package that adds some extra editor attributes to help you create clean and interactive inspector to enhance your workflow.

# Attributes

## ShowIf

Show/Hide fields based on the provided condition

### Demo Code

```csharp
public bool showGameObject;
[ShowIf("showGameObject")]
public GameObject selectedGameObject;
```


