using System;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2003C71")]
public class SlotDataAssetExt : SlotDataAsset
{
	[Token(Token = "0x4019B06")]
	[FieldOffset(Offset = "0x44")]
	public AdditiveInfo additiveInfo;

	[Token(Token = "0x6018217")]
	[Address(RVA = "0x2DF0ABC", Offset = "0x2DF0ABC", VA = "0x2DF0ABC")]
	public SlotDataAssetExt()
	{
	}

	[Token(Token = "0x6018218")]
	[Address(RVA = "0x2DF0AC0", Offset = "0x2DF0AC0", VA = "0x2DF0AC0", Slot = "8")]
	public override AdditiveInfo GetAdditiveInfo()
	{
		return null;
	}
}
