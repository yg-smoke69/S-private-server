using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021D1")]
public class UIMallADsItemController : UIBaseController
{
	[Token(Token = "0x400D36B")]
	[FieldOffset(Offset = "0x28")]
	private UIMallADsItemView m_View;

	[Token(Token = "0x400D36C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_SystemType;

	[Token(Token = "0x400D36D")]
	[FieldOffset(Offset = "0x30")]
	private uint m_MallItemID;

	[Token(Token = "0x400D36E")]
	[FieldOffset(Offset = "0x34")]
	private AdItemInfo m_Info;

	[Token(Token = "0x400D36F")]
	[FieldOffset(Offset = "0x38")]
	private string m_V2NaviPara;

	[Token(Token = "0x600B512")]
	[Address(RVA = "0x18E9FBC", Offset = "0x18E9FBC", VA = "0x18E9FBC")]
	public UIMallADsItemController()
	{
	}

	[Token(Token = "0x600B513")]
	[Address(RVA = "0x18EA040", Offset = "0x18EA040", VA = "0x18EA040")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B514")]
	[Address(RVA = "0x18EA0E4", Offset = "0x18EA0E4", VA = "0x18EA0E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B515")]
	[Address(RVA = "0x18EA2D0", Offset = "0x18EA2D0", VA = "0x18EA2D0")]
	private void OnItemSelect()
	{
	}

	[Token(Token = "0x600B516")]
	[Address(RVA = "0x18EA9E0", Offset = "0x18EA9E0", VA = "0x18EA9E0")]
	private void SendBannerClickLog(uint id)
	{
	}

	[Token(Token = "0x600B517")]
	[Address(RVA = "0x18EA7CC", Offset = "0x18EA7CC", VA = "0x18EA7CC")]
	private uint GetMainType(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x600B518")]
	[Address(RVA = "0x18EA844", Offset = "0x18EA844", VA = "0x18EA844")]
	private uint GetSubType1(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x600B519")]
	[Address(RVA = "0x18EA8C8", Offset = "0x18EA8C8", VA = "0x18EA8C8")]
	private uint GetSubType2(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x600B51A")]
	[Address(RVA = "0x18EA954", Offset = "0x18EA954", VA = "0x18EA954")]
	private uint GetSubType3(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x600B51B")]
	[Address(RVA = "0x18EABEC", Offset = "0x18EABEC", VA = "0x18EABEC")]
	public void RefreshAdData(AdItemInfo info)
	{
	}

	[Token(Token = "0x600B51C")]
	[Address(RVA = "0x18EAF38", Offset = "0x18EAF38", VA = "0x18EAF38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
