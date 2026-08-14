using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200239D")]
public class LineToneDragEventArg
{
	[Token(Token = "0x400DDD9")]
	[FieldOffset(Offset = "0x8")]
	public bool isStart;

	[Token(Token = "0x400DDDA")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 pos;

	[Token(Token = "0x600C816")]
	[Address(RVA = "0xEC5C08", Offset = "0xEC5C08", VA = "0xEC5C08")]
	public LineToneDragEventArg()
	{
	}
}
