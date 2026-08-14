using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B74")]
public interface IJsonWrapper : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
{
	[Token(Token = "0x17001826")]
	bool IsArray
	{
		[Token(Token = "0x6017AAD")]
		get;
	}

	[Token(Token = "0x17001827")]
	bool IsBoolean
	{
		[Token(Token = "0x6017AAE")]
		get;
	}

	[Token(Token = "0x17001828")]
	bool IsDouble
	{
		[Token(Token = "0x6017AAF")]
		get;
	}

	[Token(Token = "0x17001829")]
	bool IsInt
	{
		[Token(Token = "0x6017AB0")]
		get;
	}

	[Token(Token = "0x1700182A")]
	bool IsLong
	{
		[Token(Token = "0x6017AB1")]
		get;
	}

	[Token(Token = "0x1700182B")]
	bool IsObject
	{
		[Token(Token = "0x6017AB2")]
		get;
	}

	[Token(Token = "0x1700182C")]
	bool IsString
	{
		[Token(Token = "0x6017AB3")]
		get;
	}

	[Token(Token = "0x6017AB4")]
	bool GetBoolean();

	[Token(Token = "0x6017AB5")]
	double GetDouble();

	[Token(Token = "0x6017AB6")]
	int GetInt();

	[Token(Token = "0x6017AB7")]
	JsonType GetJsonType();

	[Token(Token = "0x6017AB8")]
	long GetLong();

	[Token(Token = "0x6017AB9")]
	string GetString();

	[Token(Token = "0x6017ABA")]
	void SetBoolean(bool val);

	[Token(Token = "0x6017ABB")]
	void SetDouble(double val);

	[Token(Token = "0x6017ABC")]
	void SetInt(int val);

	[Token(Token = "0x6017ABD")]
	void SetJsonType(JsonType type);

	[Token(Token = "0x6017ABE")]
	void SetLong(long val);

	[Token(Token = "0x6017ABF")]
	void SetString(string val);

	[Token(Token = "0x6017AC0")]
	string ToJson();

	[Token(Token = "0x6017AC1")]
	void ToJson(JsonWriter writer);
}
