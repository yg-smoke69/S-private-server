using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DF4")]
public class LimitedCardDataManager : SingletonModule<LimitedCardDataManager>
{
	[Token(Token = "0x40119EC")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, LimitedCardData> m_dictTypeToLimitedCardData;

	[Token(Token = "0x6013424")]
	[Address(RVA = "0xEC2724", Offset = "0xEC2724", VA = "0xEC2724")]
	public LimitedCardDataManager()
	{
	}

	[Token(Token = "0x6013425")]
	[Address(RVA = "0xEC27E8", Offset = "0xEC27E8", VA = "0xEC27E8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013426")]
	[Address(RVA = "0xEC2910", Offset = "0xEC2910", VA = "0xEC2910", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013427")]
	[Address(RVA = "0xEC29D8", Offset = "0xEC29D8", VA = "0xEC29D8", Slot = "8")]
	protected override void OnUnloadMemeory()
	{
	}

	[Token(Token = "0x6013428")]
	[Address(RVA = "0xEC2AB8", Offset = "0xEC2AB8", VA = "0xEC2AB8", Slot = "9")]
	protected override void OnReloadMemory()
	{
	}

	[Token(Token = "0x6013429")]
	[Address(RVA = "0xEC2C28", Offset = "0xEC2C28", VA = "0xEC2C28")]
	public LimitedCardData FindLimitedCardDataById(uint iid)
	{
		return null;
	}

	[Token(Token = "0x601342A")]
	[Address(RVA = "0xEC2D10", Offset = "0xEC2D10", VA = "0xEC2D10")]
	public uint GetItemExpireMins(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x601342B")]
	[Address(RVA = "0xEC2D98", Offset = "0xEC2D98", VA = "0xEC2D98")]
	public CSSharedItemDataManager.StoreQuality GetEffectItemQuality(uint id)
	{
		return default(CSSharedItemDataManager.StoreQuality);
	}

	[Token(Token = "0x601342C")]
	[Address(RVA = "0xEC2ED0", Offset = "0xEC2ED0", VA = "0xEC2ED0")]
	public void _003C_003EiFixBaseProxy_OnUnloadMemeory()
	{
	}

	[Token(Token = "0x601342D")]
	[Address(RVA = "0xEC2ED4", Offset = "0xEC2ED4", VA = "0xEC2ED4")]
	public void _003C_003EiFixBaseProxy_OnReloadMemory()
	{
	}
}
