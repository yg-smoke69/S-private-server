using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002A61")]
public class UIPointsRaceController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010466")]
	[FieldOffset(Offset = "0x28")]
	private UIPointsRaceView m_View;

	[Token(Token = "0x4010467")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelClanRace m_UIModelClanRace;

	[Token(Token = "0x4010468")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CurStageID;

	[Token(Token = "0x4010469")]
	[FieldOffset(Offset = "0x34")]
	private List<UIPointsRaceClanItemController> m_ClanItems;

	[Token(Token = "0x401046A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsClaimedClanAwards;

	[Token(Token = "0x401046B")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIPointsRaceIndividualItemController> m_IndividualItems;

	[Token(Token = "0x401046C")]
	[FieldOffset(Offset = "0x40")]
	private bool m_HasGetRaceInfo;

	[Token(Token = "0x60113D6")]
	[Address(RVA = "0x223C6B4", Offset = "0x223C6B4", VA = "0x223C6B4")]
	public UIPointsRaceController()
	{
	}

	[Token(Token = "0x60113D7")]
	[Address(RVA = "0x223C7A0", Offset = "0x223C7A0", VA = "0x223C7A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113D8")]
	[Address(RVA = "0x223C804", Offset = "0x223C804", VA = "0x223C804", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60113D9")]
	[Address(RVA = "0x223C848", Offset = "0x223C848", VA = "0x223C848", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113DA")]
	[Address(RVA = "0x223CBE4", Offset = "0x223CBE4", VA = "0x223CBE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113DB")]
	[Address(RVA = "0x223CC2C", Offset = "0x223CC2C", VA = "0x223CC2C")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60113DC")]
	[Address(RVA = "0x223CC34", Offset = "0x223CC34", VA = "0x223CC34", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60113DD")]
	[Address(RVA = "0x223E1A4", Offset = "0x223E1A4", VA = "0x223E1A4")]
	private void UpdateIndividualItems()
	{
	}

	[Token(Token = "0x60113DE")]
	[Address(RVA = "0x223DBC0", Offset = "0x223DBC0", VA = "0x223DBC0")]
	private float GetProgressValue()
	{
		return default(float);
	}

	[Token(Token = "0x60113DF")]
	[Address(RVA = "0x223EA60", Offset = "0x223EA60", VA = "0x223EA60")]
	public void OnClickPointsRank()
	{
	}

	[Token(Token = "0x60113E0")]
	[Address(RVA = "0x223ED1C", Offset = "0x223ED1C", VA = "0x223ED1C")]
	private void OnClickClaimClanAward()
	{
	}

	[Token(Token = "0x60113E1")]
	[Address(RVA = "0x223ED48", Offset = "0x223ED48", VA = "0x223ED48")]
	private void OnClickRaceTips()
	{
	}

	[Token(Token = "0x60113E2")]
	[Address(RVA = "0x223E48C", Offset = "0x223E48C", VA = "0x223E48C")]
	private void UpdateMyPoints(uint myPoints)
	{
	}
}
