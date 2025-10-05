# 📚 InfyUSDK - Integration & Usage Guide

## ✅ Step 1: Download the Framework

### Visit the GitHub Repository
Go to the repository for **InfyUSDK**:  
🔗 [https://github.com/Infyu-Labs/infyu_track_unity_ios_framework.git](https://github.com/Infyu-Labs/infyu_track_unity_ios_framework.git)

### Download the Framework
1. Click on **Code → Download ZIP** to download the framework.  
2. Unzip the downloaded file.  
3. Inside the folder, you’ll find `InfyUSDK.xcframework`.

---

## ✅ Step 2: Add to Your Project

1. Open your Xcode project.  
2. Add `InfyUSDK.xcframework` to your project:  
   - Right-click on your project name in the **Project Navigator** and select **Add Files to "YourProjectName"**.  
   - Choose the `InfyUSDK.xcframework` from the folder where it was unzipped.  
   - Ensure **Copy items if needed** is checked, then click **Add**.

### Ensure Framework is Linked
- Go to **Build Settings → Framework Search Paths** and make sure the path to the framework is added (if not done automatically).  
- In **General → Frameworks, Libraries, and Embedded Content**, ensure `InfyUSDK.xcframework` is listed and the **Embed** option is set to **Embed & Sign**.

---

## ✅ Step 3: Import the Framework
In any Swift file where you want to use **InfyUSDK**, add the following import statement:

```swift
import InfyUSDK
```

---
## ✅ Step 4: Usage Examples

### 🔐 Login / Logout
```swift
InfyUSDK.login("your_cuid_here")
InfyUSDK.logout()
```

---

### 👤 Set User Profile Data

| Property | Example |
|-----------|----------|
| First Name | `InfyUSDK.SetFirstName("John")` |
| Last Name | `InfyUSDK.SetLastName("Doe")` |
| Email | `InfyUSDK.SetEmail("john@example.com")` |
| Phone Number | `InfyUSDK.SetPhoneNumber("+1234567890")` |
| Birth Date | `InfyUSDK.SetBirthDate("1990-01-01")` |
| Gender | `InfyUSDK.SetGender("Male")` |
| Company | `InfyUSDK.SetCompany("Example Corp")` |
| Country | `InfyUSDK.SetCountry("India")` |
| City | `InfyUSDK.SetCity("Mumbai")` |
| Region | `InfyUSDK.SetRegion("Maharashtra")` |
| Locality | `InfyUSDK.SetLocality("Andheri")` |
| Postal Code | `InfyUSDK.SetPostalCode("400093")` |

---

### ✅ Add Custom User Attributes
```swift
let customAttributes = [
    "deviceType": "iPhone",
    "preferredLanguage": "English"
]
InfyUSDK.customUserAttribute(customAttributes)
```

---

### 🔔 Push Notification Integration

#### 📥 Request Permission
In your `AppDelegate.swift`:
```swift
InfyUSDK.registerForPushNotifications()
```

#### 📲 Register Device Token
```swift
func application(_ application: UIApplication, didRegisterForRemoteNotificationsWithDeviceToken deviceToken: Data) {
    InfyUSDK.registerDeviceToken(deviceToken)
}
```

#### ⏰ Schedule a Local Notification
```swift
InfyUSDK.scheduleNotification(bundleID: "com.yourcompany.yourapp")
```

---

### ✅ Sample Flow
```swift
// User login
InfyUSDK.login("USER_123")

// Set user profile
InfyUSDK.SetFirstName("Brinda")
InfyUSDK.SetLastName("Davda")
InfyUSDK.SetEmail("brinda@example.com")
InfyUSDK.SetPhoneNumber("+919999999999")
InfyUSDK.SetCountry("India")

// Register for notifications
InfyUSDK.registerForPushNotifications()

// Logout
InfyUSDK.logout()
```

---

### ✅ Info.plist Configuration

#### 1. App Transport Security
```xml
<key>NSAppTransportSecurity</key>
<dict>
    <key>NSAllowsArbitraryLoads</key>
    <true/>
</dict>
```

#### 2. Push Notification Support
```xml
<key>UIBackgroundModes</key>
<array>
    <string>fetch</string>
    <string>remote-notification</string>
</array>

<key>NSUserTrackingUsageDescription</key>
<string>We use push notifications to notify you of important updates.</string>
```

---

### ✅ System Event Tracking (Unity Compatible)
If integrating with Unity via C code bridging, use the following exported function:

```swift
@MainActor
@_cdecl("trackSystemEvent")
public func trackSystemEvent(eventName: UnsafePointer<CChar>) {
    let eventNameString = String(cString: eventName)
    EventTrackingManager.systemEvent(eventKey: eventNameString)
}
```

Call this function from Unity or C/C++ based plugins.

---

### ✅ Final Notes
- All network traffic should be secure and authorized using your API key.  
- Handle permission requests (push, tracking, etc.) properly in your app.  
- Control the verbosity of logs using flags in `Constant.swift`.

---

### 🧑‍💻 For Support
For issues, raise a GitHub issue or contact the **Infyu Labs** team directly.

**Happy Tracking! 🚀**
