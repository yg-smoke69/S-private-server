using COW.Gameplay.UGC.BlockEdit;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB2")]
public class BE_Base : MonoBehaviour
{
	[Token(Token = "0x400623B")]
	[FieldOffset(Offset = "0xC")]
	protected BlockData BOPLAOANKBI;

	[Token(Token = "0x400623C")]
	[FieldOffset(Offset = "0x10")]
	protected bool KOPCPKNOAME;

	[Token(Token = "0x17000714")]
	public BlockData CLCFBJIKGBN
	{
		[Token(Token = "0x6005894")]
		[Address(RVA = "0x1604574", Offset = "0x1604574", VA = "0x1604574", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005895")]
		[Address(RVA = "0x16045CC", Offset = "0x16045CC", VA = "0x16045CC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000715")]
	public bool NBAFOEGLFAE
	{
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x16046D8", Offset = "0x16046D8", VA = "0x16046D8", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005897")]
		[Address(RVA = "0x1604730", Offset = "0x1604730", VA = "0x1604730", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x6005893")]
	[Address(RVA = "0x160456C", Offset = "0x160456C", VA = "0x160456C")]
	public BE_Base()
	{
	}

	[Token(Token = "0x6005898")]
	[Address(RVA = "0x1604790", Offset = "0x1604790", VA = "0x1604790", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6005899")]
	[Address(RVA = "0x16048F8", Offset = "0x16048F8", VA = "0x16048F8", Slot = "9")]
	public virtual void CheckBlockLegalty()
	{
	}
}
