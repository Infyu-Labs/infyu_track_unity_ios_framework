using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using AOT;

namespace InfyUSDKBridge{
    public class InfyUSDK{

        [DllImport("__Internal")]
        private static extern void setLicenseCode(string code);

        [DllImport("__Internal")]
        private static extern void login(string s);
        
        [DllImport("__Internal")]
        private static extern void logout();

        [DllImport("__Internal")] private static extern void setFirstName(string firstName);
        [DllImport("__Internal")] private static extern void setLastName(string lastName);
        [DllImport("__Internal")] private static extern void setEmail(string email);
        [DllImport("__Internal")] private static extern void setPhone(string phone);
        [DllImport("__Internal")] private static extern void setBirthDate(string birthDate);
        [DllImport("__Internal")] private static extern void setGender(string gender);
        [DllImport("__Internal")] private static extern void setCompany(string company);
        [DllImport("__Internal")] private static extern void setCountry(string country);
        [DllImport("__Internal")] private static extern void setCity(string city);
        [DllImport("__Internal")] private static extern void setRegion(string region);
        [DllImport("__Internal")] private static extern void setLocality(string locality);
        [DllImport("__Internal")] private static extern void setPostalCode(string postalCode);
        // Declare the external Swift function that sets custom attributes
        [DllImport("__Internal")]
        private static extern void setCustomAttributes(string customAttributesJson);

        [DllImport("__Internal")]
        private static extern void trackEventWithAttributes(string s, string attributes);

        // Register the device token
        [DllImport("__Internal")]
        private static extern void registerDeviceToken(string deviceToken);

        // // Register for push notifications
        [DllImport("__Internal")]
        private static extern void registerForPushNotifications();

        // // Send push notification credentials (Bundle ID)
        [DllImport("__Internal")]
        private static extern void sendPushNotificationCredetionals(string bundleID);

        // // Send a test push notification
        [DllImport("__Internal")]
        private static extern void sendTextPushNotification(string bundleID);


        // [DllImport("__Internal")]
        // private static extern void trackEvent(string s);

        // Import the Swift screen tracking function
        [DllImport("__Internal")]
        private static extern void trackScreenData(string screenName, string screenDataJson);
        
        // Import the Swift system-event tracking function
        [DllImport("__Internal")]
        private static extern void trackSystemEvent(string eventName);
        
        public static void trackSystemEvent(string eventName)
        {
           Debug.Log($"Calling SystemEventName: {eventName}");
           
            // Ensure this works only on iOS
            #if UNITY_IOS && !UNITY_EDITOR
            trackSystemEvent(code);
            #endif

            Debug.Log("SystemEventName function executed in Swift.");
        }


        public static void SetLicenseCode(string code)
        {
            Debug.Log($"Calling LicenseCode: {code}");

            // Ensure this works only on iOS
            #if UNITY_IOS && !UNITY_EDITOR
            setLicenseCode(code);
            #endif

            Debug.Log("SetLicenseCode function executed in Swift.");
        }

        public static void Login(string cuid)
        {
            Debug.Log($"Calling login with CUID: {cuid}");

            // Ensure this works only on iOS
            #if UNITY_IOS && !UNITY_EDITOR
            login(cuid);
            #endif

            Debug.Log("Login function executed in Swift.");
        }


        public static void LogoutUser()
        {   
            Debug.Log("Logging out user...");

            #if UNITY_IOS && !UNITY_EDITOR
            logout();
            #endif

            Debug.Log("Logout function executed in Swift.");
        }

        // Static method to set first name
    public static void SetFirstName(string firstName)
    {
        Debug.Log($"Setting First Name: {firstName}");
        #if UNITY_IOS && !UNITY_EDITOR
        setFirstName(firstName);
        #endif
    }

    // Static method to set last name
    public static void SetLastName(string lastName)
    {
        Debug.Log($"Setting Last Name: {lastName}");
        #if UNITY_IOS && !UNITY_EDITOR
        setLastName(lastName);
        #endif
    }

    // Static method to set email
    public static void SetEmail(string email)
    {
        Debug.Log($"Setting Email: {email}");
        #if UNITY_IOS && !UNITY_EDITOR
        setEmail(email);
        #endif
    }

    // Static method to set phone
    public static void SetPhone(string phone)
    {
        Debug.Log($"Setting Phone: {phone}");
        #if UNITY_IOS && !UNITY_EDITOR
        setPhone(phone);
        #endif
    }

    // Static method to set birth date
    public static void SetBirthDate(string birthDate)
    {
        Debug.Log($"Setting Birth Date: {birthDate}");
        #if UNITY_IOS && !UNITY_EDITOR
        setBirthDate(birthDate);
        #endif
    }

    // Static method to set gender
    public static void SetGender(string gender)
    {
        Debug.Log($"Setting Gender: {gender}");
        #if UNITY_IOS && !UNITY_EDITOR
        setGender(gender);
        #endif
    }

    // Static method to set company
    public static void SetCompany(string company)
    {
        Debug.Log($"Setting Company: {company}");
        #if UNITY_IOS && !UNITY_EDITOR
        setCompany(company);
        #endif
    }

    // Static method to set country
    public static void SetCountry(string country)
    {
        Debug.Log($"Setting Country: {country}");
        #if UNITY_IOS && !UNITY_EDITOR
        setCountry(country);
        #endif
    }

    // Static method to set city
    public static void SetCity(string city)
    {
        Debug.Log($"Setting City: {city}");
        #if UNITY_IOS && !UNITY_EDITOR
        setCity(city);
        #endif
    }

    // Static method to set region
    public static void SetRegion(string region)
    {
        Debug.Log($"Setting Region: {region}");
        #if UNITY_IOS && !UNITY_EDITOR
        setRegion(region);
        #endif
    }

    // Static method to set locality
    public static void SetLocality(string locality)
    {
        Debug.Log($"Setting Locality: {locality}");
        #if UNITY_IOS && !UNITY_EDITOR
        setLocality(locality);
        #endif
    }

    // Static method to set postal code
    public static void SetPostalCode(string postalCode)
    {
        Debug.Log($"Setting Postal Code: {postalCode}");
        #if UNITY_IOS && !UNITY_EDITOR
        setPostalCode(postalCode);
        #endif
    }

    // Method to call Swift function for setting custom user attributes
    public static void SetCustomAttributes(Dictionary<string, object> customAttributes)
    {
        var json = new JSONObject(customAttributes);
        Debug.Log($"attributes are in: {json}");

        // Call the Swift function through the external declaration
        #if UNITY_IOS && !UNITY_EDITOR
        setCustomAttributes(json.ToString());
        #endif
    }


    // Tracking events
    public static void TrackEvent(string eventName, Dictionary<string, object> attributes)
    {
            #if UNITY_IOS
            var json = new JSONObject(attributes);
            Debug.Log($"attributes are in: {json}");
            trackEventWithAttributes(eventName, json.ToString());
            #endif
    }


    // Method to register the device token (used to identify the device for push notifications)
        public static void RegisterDeviceToken(string deviceToken) {
            Debug.Log($"Registering Device Token: {deviceToken}");
            
            #if UNITY_IOS && !UNITY_EDITOR
            registerDeviceToken(deviceToken);
            #endif
            
            Debug.Log("Device Token registration function called.");
        }

    // Method to register for push notifications
        public static void RegisterForPushNotifications() {
            Debug.Log("Registering for Push Notifications...");

            #if UNITY_IOS && !UNITY_EDITOR
            registerForPushNotifications();
            #endif

            Debug.Log("Push Notifications registration function called.");
        }

        // Method to send push notification credentials to the server (like the Bundle ID)
        public static void SendPushNotificationCredentials(string bundleID) {
            Debug.Log($"Sending Push Notification Credentials: Bundle ID = {bundleID}");
            
            #if UNITY_IOS && !UNITY_EDITOR
            sendPushNotificationCredetionals(bundleID);
            #endif
            
            Debug.Log("Push Notification Credentials sent.");
        }

        // Method to send a test push notification
        public static void SendTextPushNotification(string bundleID) {
            Debug.Log($"Sending Test Push Notification to Bundle ID: {bundleID}");

            #if UNITY_IOS && !UNITY_EDITOR
            sendTextPushNotification(bundleID);
            #endif

            Debug.Log("Test Push Notification sent.");
        }

        // Send screen name and data to Swift
        public static void TrackScreen(string screenName, Dictionary<string, string> screenData)
        {
            if (string.IsNullOrEmpty(screenName))
            {
                Debug.LogWarning("Screen name is required for tracking.");
                return;
            }

            string json = MiniJSON.Json.Serialize(screenData);

            Debug.Log($"📲 Sending screen tracking:\n🖥 Screen: {screenName}\n📦 Data: {json}");

            #if UNITY_IOS && !UNITY_EDITOR
                trackScreenData(screenName, json);
            #endif
        }

    }
}
