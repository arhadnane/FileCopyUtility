# FileCopyUtility

FileCopyUtility est une application console en C# qui permet de copier tout le contenu d'un dossier source vers un dossier de destination, y compris les sous-dossiers et leurs fichiers.

## Caractéristiques

- Copie tous les fichiers d'un dossier source vers un dossier de destination.
- Copie récursive des sous-dossiers et de leurs contenus.
- Écrase les fichiers existants dans le dossier de destination.

## Prérequis

- .NET 9.0
- Visual Studio 2022

## Installation

1. Clonez le dépôt : git clone https://github.com/votre-utilisateur/FileCopyUtility.git
2. Ouvrez le projet dans Visual Studio 2022.

## Utilisation

1. Modifiez le fichier `Program.cs` pour spécifier les chemins des dossiers source et destination :
   - string sourceDirectory = @"C:\SourceFolder";
   - string destinationDirectory = @"C:\DestinationFolder";
   - FileCopyUtility.CopyDirectory(sourceDirectory, destinationDirectory);

2. Exécutez l'application.

## Tests

Ce projet utilise `xUnit` pour les tests unitaires. Pour exécuter les tests :

1. Ouvrez l'Explorateur de tests dans Visual Studio.
2. Cliquez sur **Exécuter tout** pour exécuter tous les tests.

Le fichier de test `FileCopyUtilityTests.cs` contient un test unitaire pour vérifier que la méthode `CopyDirectory` copie correctement tous les fichiers et sous-dossiers.

## Contribution

Les contributions sont les bienvenues ! Veuillez soumettre une pull request pour toute amélioration ou correction de bug.

## Licence

Ce projet est sous licence MIT: https://opensource.org/license/mit
  
    
