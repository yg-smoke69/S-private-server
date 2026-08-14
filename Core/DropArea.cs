using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000785")]
public class DropArea : MetaObject
{
	[Token(Token = "0x4004E5C")]
	[FieldOffset(Offset = "0x14")]
	public bool Enable;

	[Token(Token = "0x4004E5D")]
	[FieldOffset(Offset = "0x18")]
	public float DropInterval;

	[Token(Token = "0x4004E5E")]
	[FieldOffset(Offset = "0x1C")]
	public float Deviation;

	[Token(Token = "0x4004E5F")]
	[FieldOffset(Offset = "0x20")]
	public float DestoryTime;

	[Token(Token = "0x4004E60")]
	[FieldOffset(Offset = "0x24")]
	public List<DropGroup> DropGroups;

	[Token(Token = "0x600305B")]
	[Address(RVA = "0x232479C", Offset = "0x232479C", VA = "0x232479C")]
	public DropArea()
	{
	}
}
