# XamarinUnityBinding

__[Update V2]__ Recently I'm working on an Xamarin.Forms Unity3d-View for iOS and Android. See https://github.com/FlorianAuer/UnityView4Xamarin.Forms


Xamarin iOS binding project to bind a modified UnityFramework.framework file

Instructions:
1. Download this repo
2. Open solution (UnityBinding.sln)
3. Follow the steps to build [modified Unity as a Library Sample](https://github.com/FlorianAuer/Unity_as_a_Library-Xamarin-example)
4. Add UnityFramework.framework file to Native References of UnityBinding (Generated by Unity when exporting the Xcode project)


These steps work with the reduced API of the UnityFramework to make it simpler to bind (See [custom Unity as a Library Sample](https://github.com/FlorianAuer/Unity_as_a_Library-Xamarin-example)). Feel free to enhance this. Pull requests accepted, but keep [custom Unity as a Library Sample](https://github.com/FlorianAuer/Unity_as_a_Library-Xamarin-example) in mind.

Thanks to all the people in this [thread](https://forums.xamarin.com/discussion/161967/ios-binding-unity-as-a-library)

A Xamarin.Android Unity Binding can be found [here](https://github.com/FlorianAuer/UnityView4Xamarin.Forms)
