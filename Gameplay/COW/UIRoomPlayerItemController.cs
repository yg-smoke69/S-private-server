using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002AFA")]
public class UIRoomPlayerItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x40107CF")]
	[FieldOffset(Offset = "0x0")]
	private static Color NAME_NORMAL;

	[Token(Token = "0x40107D0")]
	[FieldOffset(Offset = "0x10")]
	private static Color NAME_NORMALSELF;

	[Token(Token = "0x40107D1")]
	[FieldOffset(Offset = "0x20")]
	private static Color NAME_WARNING;

	[Token(Token = "0x40107D2")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomPlayerItemView m_View;

	[Token(Token = "0x40107D3")]
	[FieldOffset(Offset = "0x2C")]
	private RoomPlayerInfo m_info;

	[Token(Token = "0x40107D4")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsEmptySeat;

	[Token(Token = "0x40107D5")]
	[FieldOffset(Offset = "0x34")]
	private uint m_TeamIndex;

	[Token(Token = "0x40107D6")]
	[FieldOffset(Offset = "0x38")]
	private uint m_MemberIndex;

	[Token(Token = "0x40107D7")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_MaxIconDefaultPos;

	[Token(Token = "0x40107D8")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_MaxIconMovedPos;

	[Token(Token = "0x40107D9")]
	private const uint MAX_VERSION = 2u;

	[Token(Token = "0x40107DA")]
	[FieldOffset(Offset = "0x54")]
	private UIModelCustomRoom m_Model;

	[Token(Token = "0x40107DB")]
	[FieldOffset(Offset = "0x58")]
	private AutoChangeComp m_AutoChangeComp;

	[Token(Token = "0x6011A42")]
	[Address(RVA = "0x2BDFA48", Offset = "0x2BDFA48", VA = "0x2BDFA48")]
	public UIRoomPlayerItemController()
	{
	}

	[Token(Token = "0x6011A43")]
	[Address(RVA = "0x2BDFACC", Offset = "0x2BDFACC", VA = "0x2BDFACC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A44")]
	[Address(RVA = "0x2BDFB70", Offset = "0x2BDFB70", VA = "0x2BDFB70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A45")]
	[Address(RVA = "0x2BDFF5C", Offset = "0x2BDFF5C", VA = "0x2BDFF5C")]
	private void ResetWidgetWidth()
	{
	}

	[Token(Token = "0x6011A46")]
	[Address(RVA = "0x2BE0230", Offset = "0x2BE0230", VA = "0x2BE0230", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011A47")]
	[Address(RVA = "0x2BE0364", Offset = "0x2BE0364", VA = "0x2BE0364")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x6011A48")]
	[Address(RVA = "0x2BE0DC4", Offset = "0x2BE0DC4", VA = "0x2BE0DC4")]
	private void OnGotoSeat(object data)
	{
	}

	[Token(Token = "0x6011A49")]
	[Address(RVA = "0x2BE0F40", Offset = "0x2BE0F40", VA = "0x2BE0F40")]
	public void SetUIData(RoomPlayerInfo info, int teamIndex, int memberIndex)
	{
	}

	[Token(Token = "0x6011A4A")]
	[Address(RVA = "0x2BE1FD0", Offset = "0x2BE1FD0", VA = "0x2BE1FD0")]
	private void SetSimulationInfo()
	{
	}

	[Token(Token = "0x6011A4B")]
	[Address(RVA = "0x2BE24DC", Offset = "0x2BE24DC", VA = "0x2BE24DC")]
	private void ShowSimulationInfo()
	{
	}

	[Token(Token = "0x6011A4C")]
	[Address(RVA = "0x2BE23F4", Offset = "0x2BE23F4", VA = "0x2BE23F4")]
	private void HideSimulationInfo()
	{
	}

	[Token(Token = "0x6011A4D")]
	[Address(RVA = "0x2BE2698", Offset = "0x2BE2698", VA = "0x2BE2698")]
	private void HideMaxInfo()
	{
	}

	[Token(Token = "0x6011A4E")]
	[Address(RVA = "0x2BE2944", Offset = "0x2BE2944", VA = "0x2BE2944")]
	private void ShowMaxInfo()
	{
	}

	[Token(Token = "0x6011A4F")]
	[Address(RVA = "0x2BE2760", Offset = "0x2BE2760", VA = "0x2BE2760")]
	private void CheckMaxInfoState()
	{
	}

	[Token(Token = "0x6011A50")]
	[Address(RVA = "0x2BE2300", Offset = "0x2BE2300", VA = "0x2BE2300")]
	private void SetMapResVisible(bool b)
	{
	}

	[Token(Token = "0x6011A51")]
	[Address(RVA = "0x2BE220C", Offset = "0x2BE220C", VA = "0x2BE220C")]
	private void SetVoiceVisible(bool b)
	{
	}

	[Token(Token = "0x6011A52")]
	[Address(RVA = "0x2BE2BA0", Offset = "0x2BE2BA0", VA = "0x2BE2BA0")]
	private void OnVoiceStateChange(object[] data)
	{
	}

	[Token(Token = "0x6011A53")]
	[Address(RVA = "0x2BE2E4C", Offset = "0x2BE2E4C", VA = "0x2BE2E4C")]
	private bool SwitchValidCheck(int from, int to)
	{
		return default(bool);
	}

	[Token(Token = "0x6011A54")]
	[Address(RVA = "0x2BE300C", Offset = "0x2BE300C", VA = "0x2BE300C")]
	private void UpdateNickNameAndAlias()
	{
	}

	[Token(Token = "0x6011A55")]
	[Address(RVA = "0x2BE3328", Offset = "0x2BE3328", VA = "0x2BE3328", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011A56")]
	[Address(RVA = "0x2BE33BC", Offset = "0x2BE33BC", VA = "0x2BE33BC", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011A58")]
	[Address(RVA = "0x2BE3568", Offset = "0x2BE3568", VA = "0x2BE3568")]
	private void _003COnItemClick_003Em__0()
	{
	}

	[Token(Token = "0x6011A59")]
	[Address(RVA = "0x2BE3570", Offset = "0x2BE3570", VA = "0x2BE3570")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A5A")]
	[Address(RVA = "0x2BE3578", Offset = "0x2BE3578", VA = "0x2BE3578")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
