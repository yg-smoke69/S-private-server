using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200213F")]
public class UILobbyWeaponSlotController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D077")]
	[FieldOffset(Offset = "0x28")]
	private int m_Slot;

	[Token(Token = "0x400D078")]
	[FieldOffset(Offset = "0x2C")]
	private UILobbyWeaponSlotView m_view;

	[Token(Token = "0x400D079")]
	[FieldOffset(Offset = "0x30")]
	private WeaponSkinBaseInfo m_ItemData;

	[Token(Token = "0x400D07A")]
	[FieldOffset(Offset = "0x34")]
	private UIModelWeaponRack m_Data;

	[Token(Token = "0x400D07B")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsDragOver;

	[Token(Token = "0x400D07C")]
	private const string CLOSEKEY = "HDWeaponSlot";

	[Token(Token = "0x600AEC1")]
	[Address(RVA = "0x21E4EB8", Offset = "0x21E4EB8", VA = "0x21E4EB8")]
	public UILobbyWeaponSlotController()
	{
	}

	[Token(Token = "0x600AEC2")]
	[Address(RVA = "0x21E4F3C", Offset = "0x21E4F3C", VA = "0x21E4F3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AEC3")]
	[Address(RVA = "0x21E4FE0", Offset = "0x21E4FE0", VA = "0x21E4FE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AEC4")]
	[Address(RVA = "0x21E5448", Offset = "0x21E5448", VA = "0x21E5448", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AEC5")]
	[Address(RVA = "0x21E5610", Offset = "0x21E5610", VA = "0x21E5610")]
	public void SetViewData(int slot, uint weaponID)
	{
	}

	[Token(Token = "0x600AEC6")]
	[Address(RVA = "0x21E5A70", Offset = "0x21E5A70", VA = "0x21E5A70")]
	public void SendCreateEvent(WeaponSkinBaseInfo info)
	{
	}

	[Token(Token = "0x600AEC7")]
	[Address(RVA = "0x21E5C7C", Offset = "0x21E5C7C", VA = "0x21E5C7C")]
	public void OnDragOver()
	{
	}

	[Token(Token = "0x600AEC8")]
	[Address(RVA = "0x21E5E4C", Offset = "0x21E5E4C", VA = "0x21E5E4C")]
	public void OnDragOut()
	{
	}

	[Token(Token = "0x600AEC9")]
	[Address(RVA = "0x21E57B8", Offset = "0x21E57B8", VA = "0x21E57B8")]
	private void SetCloneObject()
	{
	}

	[Token(Token = "0x600AECA")]
	[Address(RVA = "0x21E601C", Offset = "0x21E601C", VA = "0x21E601C")]
	public bool HasWeaponInSlot()
	{
		return default(bool);
	}

	[Token(Token = "0x600AECB")]
	[Address(RVA = "0x21E6080", Offset = "0x21E6080", VA = "0x21E6080")]
	public void OnClickDeleteButton()
	{
	}

	[Token(Token = "0x600AECC")]
	[Address(RVA = "0x21E6490", Offset = "0x21E6490", VA = "0x21E6490")]
	private void OnClickSlotButton()
	{
	}

	[Token(Token = "0x600AECD")]
	[Address(RVA = "0x21E6830", Offset = "0x21E6830", VA = "0x21E6830")]
	private void OnSlotButtonClicked(object[] data)
	{
	}

	[Token(Token = "0x600AECE")]
	[Address(RVA = "0x21E69A4", Offset = "0x21E69A4", VA = "0x21E69A4")]
	private void OnRemoveDeleteButton(object[] data)
	{
	}

	[Token(Token = "0x600AECF")]
	[Address(RVA = "0x21E6B84", Offset = "0x21E6B84", VA = "0x21E6B84")]
	public void OnApplicationPause(bool pauseState)
	{
	}

	[Token(Token = "0x600AED0")]
	[Address(RVA = "0x21E6BF0", Offset = "0x21E6BF0", VA = "0x21E6BF0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AED1")]
	[Address(RVA = "0x21E6D30", Offset = "0x21E6D30", VA = "0x21E6D30", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AED2")]
	[Address(RVA = "0x21E6DC4", Offset = "0x21E6DC4", VA = "0x21E6DC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AED3")]
	[Address(RVA = "0x21E6DCC", Offset = "0x21E6DCC", VA = "0x21E6DCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
