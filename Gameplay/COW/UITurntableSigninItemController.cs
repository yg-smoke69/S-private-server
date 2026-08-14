using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B8A")]
public class UITurntableSigninItemController : UIBaseController
{
	[Token(Token = "0x4010A96")]
	[FieldOffset(Offset = "0x28")]
	private UITurntableSignInItemView m_View;

	[Token(Token = "0x4010A97")]
	[FieldOffset(Offset = "0x2C")]
	private AttendanceItem m_ItemInfo;

	[Token(Token = "0x4010A98")]
	[FieldOffset(Offset = "0x30")]
	private BaseItemInfo m_BaseItemInfo;

	[Token(Token = "0x4010A99")]
	private const uint CLAIMEDCOLOR = 1886417151u;

	[Token(Token = "0x6011FE0")]
	[Address(RVA = "0x1C351CC", Offset = "0x1C351CC", VA = "0x1C351CC")]
	public UITurntableSigninItemController()
	{
	}

	[Token(Token = "0x6011FE1")]
	[Address(RVA = "0x1C34FB0", Offset = "0x1C34FB0", VA = "0x1C34FB0")]
	public uint GetSignID()
	{
		return default(uint);
	}

	[Token(Token = "0x6011FE2")]
	[Address(RVA = "0x1C35250", Offset = "0x1C35250", VA = "0x1C35250")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011FE3")]
	[Address(RVA = "0x1C352F8", Offset = "0x1C352F8", VA = "0x1C352F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011FE4")]
	[Address(RVA = "0x1C32F2C", Offset = "0x1C32F2C", VA = "0x1C32F2C")]
	public void SetData(AttendanceItem info)
	{
	}

	[Token(Token = "0x6011FE5")]
	[Address(RVA = "0x1C357E8", Offset = "0x1C357E8", VA = "0x1C357E8")]
	private void SetQualityBG()
	{
	}

	[Token(Token = "0x6011FE6")]
	[Address(RVA = "0x1C35454", Offset = "0x1C35454", VA = "0x1C35454")]
	private void RefreshSignState()
	{
	}

	[Token(Token = "0x6011FE7")]
	[Address(RVA = "0x1C35BE8", Offset = "0x1C35BE8", VA = "0x1C35BE8")]
	private void ShowBigRewardEffect()
	{
	}

	[Token(Token = "0x6011FE8")]
	[Address(RVA = "0x1C33440", Offset = "0x1C33440", VA = "0x1C33440")]
	public void Signed()
	{
	}

	[Token(Token = "0x6011FE9")]
	[Address(RVA = "0x1C3379C", Offset = "0x1C3379C", VA = "0x1C3379C")]
	public void ShowGetRewardEffect()
	{
	}

	[Token(Token = "0x6011FEA")]
	[Address(RVA = "0x1C35CA8", Offset = "0x1C35CA8", VA = "0x1C35CA8")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x6011FEB")]
	[Address(RVA = "0x1C35F04", Offset = "0x1C35F04", VA = "0x1C35F04")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
