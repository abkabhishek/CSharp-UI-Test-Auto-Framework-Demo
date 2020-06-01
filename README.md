# C#-UI-Test-Auto-Framework-Demo

This is just a demo project to practice Web Test Automation using Selenium in C# with NUnit 3 framework. Sample Site used: https://www.mutualfundssahihai.com/

## Pre-requisite

1. Make sure dotnet 3+ is already install (check with $ dotnet --version)
2. Git should be already install to clone the repo. (Or use download & unzip)

## Installation and Running Sample Test

1. Git Clone 
```bash
git clone https://github.com/abkabhishek/CSharp-UI-Test-Auto-Framework-Demo.git
```

2. Change directory
```bash
cd CSharp-UI-Test-Auto-Framework-Demo
```

3. Build
```bash
dotnet build
```

4. Run Tests
```bash
dotnet test
```

## Structure

```python
├── Framework
│   ├── Class1.cs
├── SampleSite
│   ├── Pages
│   │   ├── App.cs // Main object to instantiate all pages.
│   │   ├── BasePage.cs // Base page to have common objects across the pages(menu)
│   │   ├── HamburgerMenu.cs // HamBurgerMenu
│   │   ├── HomePage.cs     // HomePage
│   │   └── MFCalculatorPage.cs //MFCalculatorPage
├── SampleSite.Tests
│   ├── MFCalculatorTests.cs   // NUnit Test File.
├── SampleSite.sln
└── _drivers
    └── chromedriver // ChromeDriver

```

## Note:
This demo project is build on Mac. TBT for Windows and Linux.
