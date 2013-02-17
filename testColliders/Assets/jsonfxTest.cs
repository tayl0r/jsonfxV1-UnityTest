using UnityEngine;
using System.Collections;
using JsonFx.Json;

public class TestDataStructAll {
	public int _int;
	public uint _uint;
	public float _float;
	public string _string;
	
	public TestDataStructAll() {
	}
}

public class TestDataStructUint {
	public uint _uint;
	
	public TestDataStructUint() {
	}
}

public class TestDataStructInt {
	public int _int;
	
	public TestDataStructInt() {
	}
}

public class TestDataStructFloat {
	public float _float;
	
	public TestDataStructFloat() {
	}
}

public class TestDataStructString {
	public string _string;
	
	public TestDataStructString() {
	}
}

public class jsonfxTest : MonoBehaviour {
	
	public string _json;
	public string _status;
	
	public int _intIn;
	public uint _uintIn;
	public float _floatIn;
	public string _stringIn;
	
	public int _intOut;
	public uint _uintOut;
	public float _floatOut;
	public string _stringOut;
	
	void Start() {
		_uintIn = (uint)_intIn;
	}
	
	void OnGUI() {
		GUI.Label (new Rect (10,0,100,50), _intOut.ToString());
		GUI.Label (new Rect (10,50,100,50), _uintOut.ToString());
		GUI.Label (new Rect (10,100,100,50), _floatOut.ToString());
		GUI.Label (new Rect (10,150,100,50), _stringOut);
		GUI.Label (new Rect (10,200,Screen.width-20,50), _status);
		GUI.Label (new Rect (10,250,Screen.width-20,50), _json);
		
		if (GUI.Button(new Rect(Screen.width-100f, 10, 90, 50), "test all")) {
			// write json
			var dataIn = new TestDataStructAll();
			dataIn._int = _intIn;
			dataIn._uint = _uintIn;
			dataIn._float = _floatIn;
			dataIn._string = _stringIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructAll>(_json);
				_uintOut = dataOut._uint;
				_intOut = dataOut._int;
				_floatOut = dataOut._float;
				_stringOut = dataOut._string;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}
		
		if (GUI.Button(new Rect(Screen.width-100f, 10, 90, 50), "test all")) {
			// write json
			var dataIn = new TestDataStructAll();
			dataIn._int = _intIn;
			dataIn._uint = _uintIn;
			dataIn._float = _floatIn;
			dataIn._string = _stringIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructAll>(_json);
				_uintOut = dataOut._uint;
				_intOut = dataOut._int;
				_floatOut = dataOut._float;
				_stringOut = dataOut._string;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}

		if (GUI.Button(new Rect(Screen.width-100f, 60, 90, 50), "test int")) {
			// write json
			var dataIn = new TestDataStructInt();
			dataIn._int = _intIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructInt>(_json);
				_intOut = dataOut._int;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}
		
		if (GUI.Button(new Rect(Screen.width-100f, 110, 90, 50), "test uint")) {
			// write json
			var dataIn = new TestDataStructUint();
			dataIn._uint = _uintIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructUint>(_json);
				_uintOut = dataOut._uint;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}

		if (GUI.Button(new Rect(Screen.width-100f, 160, 90, 50), "test float")) {
			// write json
			var dataIn = new TestDataStructFloat();
			dataIn._float = _floatIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructFloat>(_json);
				_floatOut = dataOut._float;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}
	
		if (GUI.Button(new Rect(Screen.width-100f, 210, 90, 50), "test string")) {
			// write json
			var dataIn = new TestDataStructString();
			dataIn._string = _stringIn;
			_json = JsonFx.Json.JsonWriter.Serialize(dataIn);

			// read all json
			try {
				var dataOut = JsonFx.Json.JsonReader.Deserialize<TestDataStructString>(_json);
				_stringOut = dataOut._string;
				_status = "success";
			} catch (System.Exception e) {
				_status = e.ToString();
				Debug.Log(e.ToString());
			}
		}

	}
	
}
