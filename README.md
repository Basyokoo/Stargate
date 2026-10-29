# Stargate

Stargate est une application de gestion de missions interplanétaires développée en C# avec Windows Forms et SQLite. Elle permet de gérer la création de missions, la sélection des planètes, la constitution d'équipes, le suivi des dépenses, les négociations, l'authentification des utilisateurs, l'inventaire des membres, les données sur les races extraterrestres et les statistiques opérationnelles. L'application offre un tableau de bord centralisé pour visualiser les missions en cours, à venir et terminées, suivre les budgets et centraliser les informations liées aux opérations spatiales.

## Présentation du projet

Stargate est une application de gestion et de pilotage d'opérations spatiales destinée à centraliser les informations relatives aux missions, aux équipes, aux ressources et aux résultats. Elle a été conçue pour fonctionner comme un outil de supervision de missions interplanétaires avec une interface visuelle orientée tableau de bord.

## Fonctionnalités principales

- Gestion de missions interplanétaires
- Sélection des planètes et création des missions
- Constitution et gestion des équipes de mission
- Authentification des utilisateurs et création de compte
- Suivi des dépenses et des budgets par mission
- Gestion des négociations et des journaux d'activité
- Consultation des données sur les races extraterrestres
- Visualisation des informations planétaires
- Tableau de bord avec filtres par statut de mission
- Statistiques et requêtes analytiques sur les données
- Base de données SQLite intégrée

## Technologies utilisées

- C# / .NET Framework 4.7.2
- Windows Forms (WinForms)
- SQLite
- BCrypt.Net pour le hachage des mots de passe
- QuestPDF pour la génération de documents
- Svg pour les éléments visuels
- StargateControlLibrary pour les composants personnalisés

## Structure du projet

```text
stargate/
├── Stargate/                     # Application principale WinForms
│   ├── Form1.cs                 # Tableau de bord principal
│   ├── Form2.cs                 # Création de mission
│   ├── Form3.cs                 # Gestion des volets associés
│   ├── Form5.cs                 # Découverte des races extraterrestres
│   ├── Form6.cs                 # Informations sur les planètes
│   ├── Form7.cs                 # Statistiques et requêtes
│   ├── FormLogin.cs             # Authentification
│   ├── FormCreerCompte.cs       # Création de compte
│   ├── FormAjoutDepense.cs      # Ajout de dépenses
│   ├── FormAjoutNegociation.cs  # Ajout de négociation
│   ├── FormAjoutJournal.cs       # Journal d'activité
│   ├── Program.cs               # Point d'entrée
│   ├── Connexion.cs             # Gestion de connexion SQLite
│   ├── MesDatas.cs              # Données partagées
│   ├── Stargate.db              # Base de données locale
│   └── packages.config          # Dépendances NuGet
├── contrôles/
│   └── StargateControlLibrary/  # Bibliothèque de composants visuels
├── README.md
└── .slnx / .csproj files
```

## Prérequis

- Visual Studio 2019 ou plus récent
- .NET Framework 4.7.2
- SQLite compatible avec .NET Framework
- NuGet restore pour récupérer les dépendances

## Installation et exécution

1. Ouvrir le projet dans Visual Studio.
2. Restaurer les packages NuGet.
3. Vérifier que le fichier de base de données `Stargate.db` est présent dans le dossier `Stargate`.
4. Compiler la solution.
5. Lancer le projet `Stargate`.

## Notes techniques

Le projet repose sur une architecture Windows Forms avec plusieurs formulaires et sous-formulaires pour représenter les différents volets fonctionnels. Les données sont stockées localement dans une base SQLite, et la logique de navigation entre les écrans est assurée via des formulaires dédiés et un helper de navigation.

---

# Stargate

Stargate is a Windows Forms application for managing interplanetary missions developed in C# with SQLite. It enables mission creation, planet selection, team formation, expense tracking, negotiations, user authentication, member inventory management, extraterrestrial species data handling and operational statistics. The application provides a centralized dashboard to view ongoing, upcoming and completed missions, monitor budgets and consolidate information related to space operations.

## Project presentation

Stargate is a space operations management and monitoring application designed to centralize information related to missions, teams, resources and outcomes. It was created as a mission supervision tool for interplanetary operations with a dashboard-oriented graphical interface.

## Main features

- Interplanetary mission management
- Planet selection and mission creation
- Mission team composition and management
- User authentication and account creation
- Expense and budget tracking per mission
- Negotiation and activity log management
- Access to extraterrestrial species data
- Planetary information views
- Dashboard with mission status filters
- Statistics and analytical queries on collected data
- Embedded SQLite database

## Technologies used

- C# / .NET Framework 4.7.2
- Windows Forms (WinForms)
- SQLite
- BCrypt.Net for password hashing
- QuestPDF for document generation
- Svg for visual elements
- StargateControlLibrary for custom UI components

## Project structure

```text
stargate/
├── Stargate/                     # Main WinForms application
│   ├── Form1.cs                 # Main dashboard
│   ├── Form2.cs                 # Mission creation
│   ├── Form3.cs                 # Related form management
│   ├── Form5.cs                 # Extraterrestrial races discovery
│   ├── Form6.cs                 # Planet information
│   ├── Form7.cs                 # Statistics and queries
│   ├── FormLogin.cs             # Authentication
│   ├── FormCreerCompte.cs       # Account creation
│   ├── FormAjoutDepense.cs      # Expense entry
│   ├── FormAjoutNegociation.cs  # Negotiation entry
│   ├── FormAjoutJournal.cs       # Activity journal
│   ├── Program.cs               # Entry point
│   ├── Connexion.cs             # SQLite connection logic
│   ├── MesDatas.cs              # Shared data
│   ├── Stargate.db              # Local database
│   └── packages.config          # NuGet dependencies
├── contrôles/
│   └── StargateControlLibrary/  # Custom UI components library
├── README.md
└── .slnx / .csproj files
```

## Requirements

- Visual Studio 2019 or newer
- .NET Framework 4.7.2
- SQLite compatible with .NET Framework
- NuGet restore to fetch dependencies

## Installation and execution

1. Open the project in Visual Studio.
2. Restore the NuGet packages.
3. Ensure that the database file `Stargate.db` is present in the `Stargate` folder.
4. Build the solution.
5. Run the `Stargate` project.

## Technical notes

The project is based on a Windows Forms architecture with several forms and sub-forms representing the different functional modules. Data is stored locally in a SQLite database, and navigation between screens is handled through dedicated forms and a navigation helper.