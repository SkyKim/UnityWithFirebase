# Unity Firebase

## Environment
- Unity 2021.3.4f1
- Firebase Unity SDK v9.0.0
- Apple M1 Pro


## Steps

1. Download Firebase Unity SDK (v9.0.0)
- https://dl.google.com/firebase/sdk/unity/dotnet4/FirebaseAnalytics_9.0.0.unitypackage
- https://dl.google.com/firebase/sdk/unity/dotnet4/FirebaseDatabase_9.0.0.unitypackage

2. Import Firebase Unity packages
- Asset > Import Package > Custom Package

3. Import "google-services.json" to Assets folder

4. Change your app information
- Edit > Project Settings > Player 
- Set [Company name] and [Product Name]
- com.Company.Product

4. Import FirebaseScript.cs
- Change [DBurl] value with your [Firebase Realtime Database address]

5. Run the script
- If there is a security error, allow firebase related apps
- Mac OS > System Preference > Security & Privacy

## Reference
- https://firebase.google.com/docs/unity/setup
