using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayInstant;

[Token(Token = "0x200007F")]
public static class PlaySignatureVerifier
{
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] GooglePlayPackageSignature;

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x350854C", Offset = "0x350854C", VA = "0x350854C")]
	public static bool VerifyGooglePlayServices(AndroidJavaObject packageManager)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x350AD0C", Offset = "0x350AD0C", VA = "0x350AD0C")]
	private static bool VerifyGooglePlayPackage(AndroidJavaObject packageManager, string packageName)
	{
		return default(bool);
	}
}
