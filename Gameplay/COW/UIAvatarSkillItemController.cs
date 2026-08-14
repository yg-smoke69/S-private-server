using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024D3")]
public class UIAvatarSkillItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E450")]
	[FieldOffset(Offset = "0x28")]
	private SkillInfo m_Data;

	[Token(Token = "0x400E451")]
	[FieldOffset(Offset = "0x2C")]
	private UIAvatarSkillItemView m_View;

	[Token(Token = "0x400E452")]
	[FieldOffset(Offset = "0x30")]
	private UIAvatarSkillSlotController slotctrl;

	[Token(Token = "0x400E453")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isActiveSkill;

	[Token(Token = "0x400E454")]
	[FieldOffset(Offset = "0x38")]
	private AvatarSkillData m_SkillData;

	[Token(Token = "0x400E455")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarProfile m_Profile;

	[Token(Token = "0x400E456")]
	[FieldOffset(Offset = "0x40")]
	private int m_MaxLevel;

	[Token(Token = "0x600D3D1")]
	[Address(RVA = "0x2F93194", Offset = "0x2F93194", VA = "0x2F93194")]
	public UIAvatarSkillItemController()
	{
	}

	[Token(Token = "0x600D3D2")]
	[Address(RVA = "0x2F93220", Offset = "0x2F93220", VA = "0x2F93220", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D3D3")]
	[Address(RVA = "0x2F93654", Offset = "0x2F93654", VA = "0x2F93654")]
	public void SetBaseDepth(int depth)
	{
	}

	[Token(Token = "0x600D3D4")]
	[Address(RVA = "0x2F93724", Offset = "0x2F93724", VA = "0x2F93724")]
	private void OnBuyClick()
	{
	}

	[Token(Token = "0x600D3D5")]
	[Address(RVA = "0x2F93DDC", Offset = "0x2F93DDC", VA = "0x2F93DDC")]
	private void GainAvatar(uint id)
	{
	}

	[Token(Token = "0x600D3D6")]
	[Address(RVA = "0x2F940E8", Offset = "0x2F940E8", VA = "0x2F940E8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D3D7")]
	[Address(RVA = "0x2F9421C", Offset = "0x2F9421C", VA = "0x2F9421C")]
	private void OnLevelClick()
	{
	}

	[Token(Token = "0x600D3D8")]
	[Address(RVA = "0x2F9448C", Offset = "0x2F9448C", VA = "0x2F9448C")]
	private void OnTipsClick()
	{
	}

	[Token(Token = "0x600D3D9")]
	[Address(RVA = "0x2F95DB0", Offset = "0x2F95DB0", VA = "0x2F95DB0")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x600D3DA")]
	[Address(RVA = "0x2F95E80", Offset = "0x2F95E80", VA = "0x2F95E80")]
	private void OnUpdateRedTips(object[] data)
	{
	}

	[Token(Token = "0x600D3DB")]
	[Address(RVA = "0x2F95F28", Offset = "0x2F95F28", VA = "0x2F95F28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D3DC")]
	[Address(RVA = "0x2F95FCC", Offset = "0x2F95FCC", VA = "0x2F95FCC")]
	private void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600D3DD")]
	[Address(RVA = "0x2F986B0", Offset = "0x2F986B0", VA = "0x2F986B0")]
	public void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600D3DE")]
	[Address(RVA = "0x2F9743C", Offset = "0x2F9743C", VA = "0x2F9743C")]
	private uint GetAvatarIdBySkillId(uint _skillid)
	{
		return default(uint);
	}

	[Token(Token = "0x600D3DF")]
	[Address(RVA = "0x2F99800", Offset = "0x2F99800", VA = "0x2F99800", Slot = "31")]
	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	[Token(Token = "0x600D3E0")]
	[Address(RVA = "0x2F99890", Offset = "0x2F99890", VA = "0x2F99890", Slot = "32")]
	public void SetPosition(Vector2 position)
	{
	}

	[Token(Token = "0x600D3E1")]
	[Address(RVA = "0x2F999B8", Offset = "0x2F999B8", VA = "0x2F999B8", Slot = "33")]
	public void SetTable2Visible(bool visible)
	{
	}

	[Token(Token = "0x600D3E2")]
	[Address(RVA = "0x2F99A48", Offset = "0x2F99A48", VA = "0x2F99A48")]
	public void GetSkillBtnAction(out List<EventDelegate> guideAction)
	{
	}

	[Token(Token = "0x600D3E3")]
	[Address(RVA = "0x2F99AD8", Offset = "0x2F99AD8", VA = "0x2F99AD8")]
	private void _003COnBuyClick_003Em__0()
	{
	}

	[Token(Token = "0x600D3E4")]
	[Address(RVA = "0x2F99B08", Offset = "0x2F99B08", VA = "0x2F99B08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D3E5")]
	[Address(RVA = "0x2F99B10", Offset = "0x2F99B10", VA = "0x2F99B10")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
