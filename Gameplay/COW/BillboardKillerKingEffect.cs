using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005B0")]
public class BillboardKillerKingEffect : MonoBehaviour
{
	[Token(Token = "0x4004389")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> KillerKingSpawnPoints;

	[Token(Token = "0x400438A")]
	[FieldOffset(Offset = "0x10")]
	public float LoopEffectInterval;

	[Token(Token = "0x400438B")]
	[FieldOffset(Offset = "0x14")]
	public float KillerKingAppearDuration;

	[Token(Token = "0x400438C")]
	[FieldOffset(Offset = "0x18")]
	public float KillerKingLoopDuration;

	[Token(Token = "0x400438D")]
	[FieldOffset(Offset = "0x1C")]
	public float KillerKingReturnDuration;

	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x180B118", Offset = "0x180B118", VA = "0x180B118")]
	public BillboardKillerKingEffect()
	{
	}
}
