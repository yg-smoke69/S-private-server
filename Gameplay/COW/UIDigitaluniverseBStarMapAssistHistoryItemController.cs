using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EF7")]
internal class UIDigitaluniverseBStarMapAssistHistoryItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400C2ED")]
	[FieldOffset(Offset = "0x38")]
	private UIDigitaluniverseBStarMapAssistHistoryItemView m_View;

	[Token(Token = "0x400C2EE")]
	[FieldOffset(Offset = "0x3C")]
	private CSDigitalUniverseBStarCraftInfoRes.PlayerInfo m_PlayerInfo;

	[Token(Token = "0x400C2EF")]
	[FieldOffset(Offset = "0x40")]
	private UIModelDigitaluniverseB m_Model;

	[Token(Token = "0x400C2F0")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsInBtnCd;

	[Token(Token = "0x6009759")]
	[Address(RVA = "0x2F0E72C", Offset = "0x2F0E72C", VA = "0x2F0E72C")]
	public UIDigitaluniverseBStarMapAssistHistoryItemController()
	{
	}

	[Token(Token = "0x600975A")]
	[Address(RVA = "0x2F0E734", Offset = "0x2F0E734", VA = "0x2F0E734")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600975B")]
	[Address(RVA = "0x2F0E7DC", Offset = "0x2F0E7DC", VA = "0x2F0E7DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600975C")]
	[Address(RVA = "0x2F0E9F4", Offset = "0x2F0E9F4", VA = "0x2F0E9F4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600975D")]
	[Address(RVA = "0x2F0EC7C", Offset = "0x2F0EC7C", VA = "0x2F0EC7C")]
	private void RefreshAssistState()
	{
	}

	[Token(Token = "0x600975E")]
	[Address(RVA = "0x2F0EE3C", Offset = "0x2F0EE3C", VA = "0x2F0EE3C")]
	private void OnBtnAssistClick()
	{
	}

	[Token(Token = "0x600975F")]
	[Address(RVA = "0x2F0F264", Offset = "0x2F0F264", VA = "0x2F0F264", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009760")]
	[Address(RVA = "0x2F0F324", Offset = "0x2F0F324", VA = "0x2F0F324", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009761")]
	[Address(RVA = "0x2F0F3B8", Offset = "0x2F0F3B8", VA = "0x2F0F3B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
