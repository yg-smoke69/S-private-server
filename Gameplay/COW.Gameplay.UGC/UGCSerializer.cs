using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CEF")]
public static class UGCSerializer
{
	[Token(Token = "0x6006209")]
	public static bool ToBytes<T>(T data, out byte[] dataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x600620A")]
	public static bool FromBytes<T>(byte[] dataBytes, out T data)
	{
		return default(bool);
	}

	[Token(Token = "0x600620B")]
	public static bool ToVersionControlProtoData<T>(T data, out JPDOLALJENI vcData)
	{
		return default(bool);
	}

	[Token(Token = "0x600620C")]
	public static bool ToProtoBufBytes<T>(T data, out byte[] dataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x600620D")]
	public static bool FromProbufBytes<T>(byte[] dataBytes, out T data)
	{
		return default(bool);
	}

	[Token(Token = "0x600620E")]
	public static bool ToJson<T>(T data, out string dataString)
	{
		return default(bool);
	}

	[Token(Token = "0x600620F")]
	public static bool FromJson<T>(string dataString, out T data)
	{
		return default(bool);
	}
}
