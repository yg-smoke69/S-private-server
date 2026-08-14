using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FA7")]
public class PinBaseInfo : CollectionBaseInfo, _Attribute
{
	[Token(Token = "0x4012289")]
	[FieldOffset(Offset = "0x20")]
	public PinData pin_data;

	[Token(Token = "0x6013EB8")]
	[Address(RVA = "0x1C05364", Offset = "0x1C05364", VA = "0x1C05364")]
	public PinBaseInfo()
	{
	}

	[Token(Token = "0x6013EB9")]
	[Address(RVA = "0x1C0536C", Offset = "0x1C0536C", VA = "0x1C0536C")]
	public PinBaseInfo(uint itemid)
	{
	}

	[Token(Token = "0x6013EBA")]
	[Address(RVA = "0x1C05648", Offset = "0x1C05648", VA = "0x1C05648")]
	public static implicit operator PinBaseInfo(Item it)
	{
		return null;
	}

	[Token(Token = "0x6013EBB")]
	[Address(RVA = "0x1C05714", Offset = "0x1C05714", VA = "0x1C05714")]
	public static implicit operator PinBaseInfo(PinData data)
	{
		return null;
	}

	[Token(Token = "0x6013EBC")]
	[Address(RVA = "0x1C057E0", Offset = "0x1C057E0", VA = "0x1C057E0", Slot = "5")]
	public override uint GetCurrentId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013EBD")]
	[Address(RVA = "0x1C05918", Offset = "0x1C05918", VA = "0x1C05918", Slot = "6")]
	public int CompareTo(PinBaseInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6013EBE")]
	[Address(RVA = "0x1C05988", Offset = "0x1C05988", VA = "0x1C05988")]
	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return default(uint);
	}
}
