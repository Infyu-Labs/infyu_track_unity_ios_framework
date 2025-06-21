# infyu_track_unity_ios_framework

This Unity SDK bridge allows seamless communication between Unity (C#) and iOS native Swift code using `[DllImport("__Internal")]`. It provides an interface for common operations like user login, event tracking, push notification registration, and more.

---

## 🔧 Setup Instructions

### ✅ Prerequisites

- Unity 2021.3+ (Recommended)
- Xcode 14+
- iOS Build Target (minimum iOS 13.0)
- Swift iOS Native Plugin integrated in `Unity-iPhone` project

---

Ensure the Swift bridging and static linking is set up correctly in your iOS project:
- Add Swift Support in Unity Build Settings
- Enable `Always Embed Swift Standard Libraries` in Xcode

---

## 🚀 How to Use

### 1. 🆔 Set License Code
```csharp
InfyUSDK.SetLicenseCode("your-license-key");
```

---

### 2. 🔐 Login & Logout
```csharp
InfyUSDK.Login("user-cuid");
InfyUSDK.LogoutUser();
```

---

### 3. 👤 Set User Info
```csharp
InfyUSDK.SetFirstName("Brinda");
InfyUSDK.SetLastName("Davda");
InfyUSDK.SetEmail("brinda@example.com");
InfyUSDK.SetPhone("+91XXXXXXXXXX");
InfyUSDK.SetBirthDate("1995-12-01");
InfyUSDK.SetGender("Female");
InfyUSDK.SetCompany("Infy");
InfyUSDK.SetCountry("India");
InfyUSDK.SetCity("Mumbai");
InfyUSDK.SetRegion("Maharashtra");
InfyUSDK.SetLocality("Andheri");
InfyUSDK.SetPostalCode("400053");
```

---

### 4. 🧩 Set Custom Attributes
```csharp
Dictionary<string, object> attributes = new Dictionary<string, object>() {
    { "role", "developer" },
    { "team", "iOS" },
    { "experience", 5 }
};
InfyUSDK.SetCustomAttributes(attributes);
```

---

### 6. 📱 Push Notification Setup

#### Register Device Token
```csharp
InfyUSDK.RegisterDeviceToken("your_device_token");
```

#### Register for Notifications
```csharp
InfyUSDK.RegisterForPushNotifications();
```

#### Send Credentials (Bundle ID)
```csharp
InfyUSDK.SendPushNotificationCredentials("com.example.yourapp");
```

#### Send Test Notification
```csharp
InfyUSDK.SendTextPushNotification("com.example.yourapp");
```

---

### 7. 📺 Screen Tracking
```csharp
InfyUSDK.TrackScreen("HomeScreen", new Dictionary<string, string> {
    { "duration", "15" },
    { "source", "deeplink" }
});
```

---

## 🛠 Debug Logs

Debug messages are printed using `Debug.Log()` in Unity and can be monitored via:
- Unity Console
- Xcode console logs (when running on a device)

