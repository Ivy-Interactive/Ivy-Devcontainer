# Ivy Devcontainer

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=Ivy-Interactive%2FIvy-Devcontainer&machine=standardLinux32gb&devcontainer_path=.devcontainer%2Fdevcontainer.json&location=EuropeWest)

This repository provides a pre-configured development container for **.NET 9** projects with the `Ivy.Console` tool pre-installed.

## 🚀 Quick Start

1. Click the **"Open in GitHub Codespaces"** badge above.
2. Wait for the Codespace to start (it will use `.devcontainer/devcontainer.json` for setup).
3. Once the dev container is ready it will start the Ivy server and open a browser showing the HelloApp. 
4. You can now make changes to `Apps/HelloApp.cs` and it will automatically hot-reload in the browser.

## 🧹 Maintaining Your Codespaces

GitHub Codespaces automatically manages your development containers, so you usually **don’t need to manually stop them**. However, here are a few tips to keep your environment clean and fast:

### **1. Auto-Suspend**
- Codespaces **automatically pause after 30 minutes of inactivity**, so you won’t be billed for CPU usage during idle time.
- When you return, your Codespace will resume where you left off.

### **2. Rebuilding the Container**
- If you make changes to `.devcontainer/devcontainer.json`, you should **rebuild the container**:
  - **VS Code:** Press `F1` → **“Codespaces: Rebuild Container”**
  - Or, from the **Codespaces tab** in GitHub, choose **“Rebuild”**.
- Rebuilding ensures all new tools and settings are applied.

### **3. Deleting Codespaces**
- You only need to delete a Codespace if:
  - You want to **free up storage or quota**.
  - You’re **done with that environment** and want to start fresh.
  - Your environment is **stuck or misconfigured** (a fresh rebuild often fixes issues).
- To delete a Codespace:
  - Go to **GitHub → Your profile → Codespaces**.
  - Find the Codespace and click **“Delete”**.

### **4. Retention Period**
- Codespaces can **auto-delete after a retention period** (set in **GitHub → Settings → Codespaces → Retention Period**).
- Adjust the period based on how long you want inactive environments to be kept.