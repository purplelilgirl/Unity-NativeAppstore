Unity-NativeAppstore
====================

Unity Plugin that allows opening of an app in the iOS and Android Appstore

iOS 
- uses SKStoreProductViewController when its available, defaults to OpenURL
- don't forget to include StoreKit.framework in Build Phases Link Binary with Libraries
- to prevent the Status Bar showing in the Appstore view, add View Controller based Status Bar to Info.plist and set it to false

Android 
- uses Uri Intent


Project Structure:

UnityProject - Unity Project folder, includes NativeappstoreHandler, NativeAppstoreTestScene

UnityPackage - Unity Package that can be imported to any Unity Project

AndroidPluginProject - source code of NativeAppstore.jar
