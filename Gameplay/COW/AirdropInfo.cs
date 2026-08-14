using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200325E")]
internal class AirdropInfo
{
	[Token(Token = "0x40132A5")]
	[FieldOffset(Offset = "0x8")]
	public int index;

	[Token(Token = "0x40132A6")]
	[FieldOffset(Offset = "0xC")]
	public List<MNGBAPBBJDC> pickups;

	[Token(Token = "0x40132A7")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 position;

	[Token(Token = "0x60153D2")]
	[Address(RVA = "0x14C43D4", Offset = "0x14C43D4", VA = "0x14C43D4")]
	public AirdropInfo()
	{
	}
}
