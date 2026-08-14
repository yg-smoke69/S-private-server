using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK;

[Token(Token = "0x200007A")]
public class SdkUnity
{
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x8")]
	private AndroidJavaObject javaSdkUnity;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x0")]
	private static SdkUnity sInstance;

	[Token(Token = "0x1700006B")]
	public static SdkUnity Instance
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x344D460", Offset = "0x344D460", VA = "0x344D460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x3468160", Offset = "0x3468160", VA = "0x3468160")]
	private SdkUnity()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x344D914", Offset = "0x344D914", VA = "0x344D914")]
	public void Call(string methodName, object[] args)
	{
	}

	[Token(Token = "0x60002D9")]
	public T Call<T>(string methodName, object[] args)
	{
		return (T)null;
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x344D950", Offset = "0x344D950", VA = "0x344D950")]
	public void SetLog(bool debug, bool error)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x344DB88", Offset = "0x344DB88", VA = "0x344DB88")]
	public void SetOverrideRootUrl(string url)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x344DD24", Offset = "0x344DD24", VA = "0x344DD24")]
	public void SetOverrideNewRootUrl(string url)
	{
	}
}
