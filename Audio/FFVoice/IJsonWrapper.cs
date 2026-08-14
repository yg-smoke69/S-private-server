using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B45")]
public interface IJsonWrapper : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
{
	[Token(Token = "0x170017D3")]
	bool IsArray
	{
		[Token(Token = "0x60178C1")]
		get;
	}

	[Token(Token = "0x170017D4")]
	bool IsBoolean
	{
		[Token(Token = "0x60178C2")]
		get;
	}

	[Token(Token = "0x170017D5")]
	bool IsDouble
	{
		[Token(Token = "0x60178C3")]
		get;
	}

	[Token(Token = "0x170017D6")]
	bool IsInt
	{
		[Token(Token = "0x60178C4")]
		get;
	}

	[Token(Token = "0x170017D7")]
	bool IsLong
	{
		[Token(Token = "0x60178C5")]
		get;
	}

	[Token(Token = "0x170017D8")]
	bool IsObject
	{
		[Token(Token = "0x60178C6")]
		get;
	}

	[Token(Token = "0x170017D9")]
	bool IsString
	{
		[Token(Token = "0x60178C7")]
		get;
	}

	[Token(Token = "0x60178C8")]
	bool GetBoolean();

	[Token(Token = "0x60178C9")]
	double GetDouble();

	[Token(Token = "0x60178CA")]
	int GetInt();

	[Token(Token = "0x60178CB")]
	JsonType GetJsonType();

	[Token(Token = "0x60178CC")]
	long GetLong();

	[Token(Token = "0x60178CD")]
	string GetString();

	[Token(Token = "0x60178CE")]
	void SetBoolean(bool val);

	[Token(Token = "0x60178CF")]
	void SetDouble(double val);

	[Token(Token = "0x60178D0")]
	void SetInt(int val);

	[Token(Token = "0x60178D1")]
	void SetJsonType(JsonType type);

	[Token(Token = "0x60178D2")]
	void SetLong(long val);

	[Token(Token = "0x60178D3")]
	void SetString(string val);

	[Token(Token = "0x60178D4")]
	string ToJson();

	[Token(Token = "0x60178D5")]
	void ToJson(JsonWriter writer);
}
