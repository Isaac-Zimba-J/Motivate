# 🌟 Motivate App

A cross-platform **.NET MAUI** mobile application that delivers **motivational quotes** to inspire you daily.  
The app fetches quotes online (from [ZenQuotes API](https://zenquotes.io)) and gracefully falls back to offline storage when there’s no internet connection.

---

## ✨ Features

- 📖 **Random Motivational Quotes** — fetch a new quote with a tap.
- 📡 **Online + Offline Support**  
  - Online: fetches fresh quotes from the **ZenQuotes API**  
  - Offline: reads from a local **SQLite database**  
- 🎨 **Modern UI** — clean card design with borders and centered layout  
- 📱 **Cross-Platform** — works on **Android, iOS, Windows, and macOS**  
- ⚡ **MVVM Architecture** using **CommunityToolkit.Mvvm** for clean separation of UI and logic  

---

## 🛠️ Tech Stack

- **.NET MAUI** — cross-platform UI framework  
- **C#** — core programming language  
- **MVVM** with `CommunityToolkit.Mvvm`  
- **SQLite** — local storage for offline quotes  
- **HttpClient** — fetches quotes from the web API  
- **Dependency Injection** — services and repositories for clean structure  

---

## 📂 Project Structure

Motivate/
│── Models/ # Data models (Quote, etc.)
│── Services/ # API & local storage services
│── Repositories/ # Data access layer
│── ViewModels/ # MVVM view models
│── Views/ # XAML pages (MainPage, etc.)
│── App.xaml # Global resources
│── MauiProgram.cs # App startup & DI setup

yaml
Copy code

---

## 🚀 Getting Started

### 1. Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  
- Visual Studio 2022 (Preview or latest) with **.NET MAUI workload** installed  

### 2. Clone the repository
```sh
git clone https://github.com/your-username/Motivate.git
cd Motivate
3. Restore dependencies
sh
Copy code
dotnet restore
4. Run the app
sh
Copy code
dotnet build
dotnet run
Or launch directly in Visual Studio on your preferred device (Android Emulator, iOS Simulator, or Windows).

📸 Screenshots
Quote Card	Fetch Button

📌 Roadmap
 Add animations (fade-in for quotes)

 Add favorite quotes saving

 Share quotes on social media

 Daily quote notification system

🙏 Credits
This app uses the free ZenQuotes API for inspirational quotes.
Big thanks to the ZenQuotes team for providing motivational content.

📜 License
This project is licensed under the MIT License.
You’re free to use, modify, and distribute it, with attribution.

👨‍💻 Author
Isaac Zimba

💼 LinkedIn

🐙 GitHub

✉️ zimbaisaacj2002@gmail.com
