using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000791")]
public class SpawnArea : MetaObject
{
	[Token(Token = "0x4004E9C")]
	[FieldOffset(Offset = "0x14")]
	public float DropInterval;

	[Token(Token = "0x4004E9D")]
	[FieldOffset(Offset = "0x18")]
	public float Deviation;

	[Token(Token = "0x4004E9E")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxAliveTime;

	[Token(Token = "0x4004E9F")]
	[FieldOffset(Offset = "0x20")]
	public List<SpawnGroup> SpawnGroups;

	[Token(Token = "0x600308A")]
	[Address(RVA = "0x21D7508", Offset = "0x21D7508", VA = "0x21D7508")]
	public SpawnArea()
	{
	}
}
