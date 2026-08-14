using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002398")]
public sealed class ToneCompletePassData
{
	[Token(Token = "0x400DDB9")]
	[FieldOffset(Offset = "0x8")]
	public readonly ToneCompleteType completeType;

	[Token(Token = "0x400DDBA")]
	[FieldOffset(Offset = "0xC")]
	public readonly Vector3 completeEffectWorldPos;

	[Token(Token = "0x400DDBB")]
	[FieldOffset(Offset = "0x18")]
	public readonly Vector3 clickEffectWorldPos;

	[Token(Token = "0x400DDBC")]
	[FieldOffset(Offset = "0x24")]
	public readonly int toneID;

	[Token(Token = "0x600C7F5")]
	[Address(RVA = "0x232A2AC", Offset = "0x232A2AC", VA = "0x232A2AC")]
	public ToneCompletePassData(ToneCompleteType type, Vector3 completeEffectWorldPos, Vector3 clickEffectWorldPos, int toneID)
	{
	}
}
