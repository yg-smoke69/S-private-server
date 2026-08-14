using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200292A")]
public class UILobbyLoadoutController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FD7B")]
	[FieldOffset(Offset = "0x28")]
	private UIModelAvatarProfile m_AvatarProfileModel;

	[Token(Token = "0x400FD7C")]
	[FieldOffset(Offset = "0x2C")]
	private UILobbyLoadoutView m_View;

	[Token(Token = "0x400FD7D")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsOldEquipped;

	[Token(Token = "0x400FD7E")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsNewEquipped;

	[Token(Token = "0x400FD7F")]
	[FieldOffset(Offset = "0x32")]
	private bool m_IsSkillEquipped;

	[Token(Token = "0x60105AD")]
	[Address(RVA = "0xDBC004", Offset = "0xDBC004", VA = "0xDBC004")]
	public UILobbyLoadoutController()
	{
	}

	[Token(Token = "0x60105AE")]
	[Address(RVA = "0xDBC088", Offset = "0xDBC088", VA = "0xDBC088")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60105AF")]
	[Address(RVA = "0xDBC12C", Offset = "0xDBC12C", VA = "0xDBC12C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60105B0")]
	[Address(RVA = "0xDBCA24", Offset = "0xDBCA24", VA = "0xDBCA24", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60105B1")]
	[Address(RVA = "0xDBCC0C", Offset = "0xDBCC0C", VA = "0xDBCC0C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60105B2")]
	[Address(RVA = "0xDBCCC4", Offset = "0xDBCCC4", VA = "0xDBCCC4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60105B3")]
	[Address(RVA = "0xDBCE70", Offset = "0xDBCE70", VA = "0xDBCE70")]
	public UIWidget GetGuideWidget()
	{
		return null;
	}

	[Token(Token = "0x60105B4")]
	[Address(RVA = "0xDBCEE0", Offset = "0xDBCEE0", VA = "0xDBCEE0")]
	public UIButton GetGuideButton()
	{
		return null;
	}

	[Token(Token = "0x60105B5")]
	[Address(RVA = "0xDBCF50", Offset = "0xDBCF50", VA = "0xDBCF50")]
	private void OnLoadOutBtnClick()
	{
	}

	[Token(Token = "0x60105B6")]
	[Address(RVA = "0xDBC4A4", Offset = "0xDBC4A4", VA = "0xDBC4A4")]
	private void UpdateLoadOuts(bool isLoadoutEquipped = false, bool isForced = false)
	{
	}

	[Token(Token = "0x60105B7")]
	[Address(RVA = "0xDBD318", Offset = "0xDBD318", VA = "0xDBD318")]
	private void OnLoadOutSelected(object[] data)
	{
	}

	[Token(Token = "0x60105B8")]
	[Address(RVA = "0xDBD150", Offset = "0xDBD150", VA = "0xDBD150")]
	private void ProcessLoadOutSprite(UISprite noloadout, UISprite loadout, bool isEquipped)
	{
	}

	[Token(Token = "0x60105B9")]
	[Address(RVA = "0xDBD408", Offset = "0xDBD408", VA = "0xDBD408")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60105BA")]
	[Address(RVA = "0xDBD410", Offset = "0xDBD410", VA = "0xDBD410")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
