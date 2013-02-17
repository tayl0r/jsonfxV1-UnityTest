jsonfxV1-UnityTest
==================

test project for Unity3d 4.x + JsonFX 1.x
(the project is named incorrectly, in the source code it's named testColliders but that is just because there's really no good way to rename a project in Unity).

In the past couple weeks JsonFX has broken for me on iOS devices (still works fine in the Editor). I think it might be caused by the latest version of Unity.

I am uploading this simple test project so others can test it on their own devices / versions of Unity.


Here is the error:

    System.MissingMethodException: Method not found: 'Default constructor not found...ctor() of System.ComponentModel.Int32Converter'.
    at System.Activator.CreateInstance (System.Type type, Boolean nonPublic) [0x00000] in <filename unknown>:0 
    at System.Activator.CreateInstance (System.Type type) [0x00000] in <filename unknown>:0 
    at System.ComponentModel.TypeDescriptor.GetConverter (System.Type type) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.TypeCoercionUtility.CoerceType (System.Type targetType, System.Object value) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.ReadNumber (System.Type expectedType) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.Read (System.Type expectedType, Boolean typeIsHint) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.ReadObject (System.Type objectType) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.Read (System.Type expectedType, Boolean typeIsHint) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.Deserialize (Int32 start, System.Type type) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.Deserialize (System.String value, Int32 start, System.Type type) [0x00000] in <filename unknown>:0 
    at JsonFx.Json.JsonReader.Deserialize[TestDataStructAll] (System.String value) [0x00000] in <filename unknown>:0 

edit: fixed the problem: http://forum.unity3d.com/threads/136720-Json.Net-iPhone-compatibility?p=1167580#post1167580
