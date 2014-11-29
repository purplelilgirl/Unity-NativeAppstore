Unity-NativeAppstore
====================

Unity Plugin that allows opening of an app in the iOS and Android Appstore

iOS - uses SKStoreProductViewController when its available, defaults to OpenURL

Android - uses Uri Intent

Project Structure:

UnityProject - Unity Project folder, includes NativeappstoreHandler, NativeAppstoreTestScene

UnityPackage - Unity Package that can be imported to any Unity Project

AndroidPluginProject - source code of NativeAppstore.jar
