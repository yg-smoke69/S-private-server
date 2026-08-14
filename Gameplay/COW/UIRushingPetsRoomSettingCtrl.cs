using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022F1")]
public class UIRushingPetsRoomSettingCtrl : UIRushingPetsCreateRoom
{
	[Token(Token = "0x400DA1E")]
	[FieldOffset(Offset = "0x90")]
	private ulong m_RoomID;

	[Token(Token = "0x400DA1F")]
	[FieldOffset(Offset = "0x98")]
	private UIModelCustomRoom m_Model;

	[Token(Token = "0x600C0B3")]
	[Address(RVA = "0x1434158", Offset = "0x1434158", VA = "0x1434158")]
	public UIRushingPetsRoomSettingCtrl()
	{
	}

	[Token(Token = "0x600C0B4")]
	[Address(RVA = "0x143415C", Offset = "0x143415C", VA = "0x143415C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C0B5")]
	[Address(RVA = "0x1434204", Offset = "0x1434204", VA = "0x1434204", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C0B6")]
	[Address(RVA = "0x14349C4", Offset = "0x14349C4", VA = "0x14349C4")]
	private void OnMaskBtnClick()
	{
	}

	[Token(Token = "0x600C0B7")]
	[Address(RVA = "0x1434BF0", Offset = "0x1434BF0", VA = "0x1434BF0", Slot = "48")]
	protected override void InitDefaultParams()
	{
	}

	[Token(Token = "0x600C0B8")]
	[Address(RVA = "0x1434DA0", Offset = "0x1434DA0", VA = "0x1434DA0", Slot = "51")]
	protected override bool NeedCheckRoomCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600C0B9")]
	[Address(RVA = "0x1434DF8", Offset = "0x1434DF8", VA = "0x1434DF8", Slot = "50")]
	protected override void ProcessConfirmRoomInfo()
	{
	}

	[Token(Token = "0x600C0BA")]
	[Address(RVA = "0x14351EC", Offset = "0x14351EC", VA = "0x14351EC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C0BB")]
	[Address(RVA = "0x14351F0", Offset = "0x14351F0", VA = "0x14351F0")]
	public void _003C_003EiFixBaseProxy_InitDefaultParams()
	{
	}

	[Token(Token = "0x600C0BC")]
	[Address(RVA = "0x14351F4", Offset = "0x14351F4", VA = "0x14351F4")]
	public bool _003C_003EiFixBaseProxy_NeedCheckRoomCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600C0BD")]
	[Address(RVA = "0x14351F8", Offset = "0x14351F8", VA = "0x14351F8")]
	public void _003C_003EiFixBaseProxy_ProcessConfirmRoomInfo()
	{
	}
}
