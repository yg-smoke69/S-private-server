using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A5C")]
public class UIPetSkillGridController : UIBaseController, _Attribute
{
	[Token(Token = "0x401044A")]
	private const int ALL_GRID_COLUMN = 1;

	[Token(Token = "0x401044B")]
	[FieldOffset(Offset = "0x28")]
	private UIPetSkillScrollViewView m_View;

	[Token(Token = "0x401044C")]
	[FieldOffset(Offset = "0x2C")]
	private UIPetSkillItemController m_CurrentSkillItemCtrl;

	[Token(Token = "0x401044D")]
	[FieldOffset(Offset = "0x30")]
	private List<PetSkillConfigInfo> m_NeedShowConfigList;

	[Token(Token = "0x401044E")]
	[FieldOffset(Offset = "0x34")]
	private uint m_CurrentSelectedSkillID;

	[Token(Token = "0x6011388")]
	[Address(RVA = "0x2C49B74", Offset = "0x2C49B74", VA = "0x2C49B74")]
	public UIPetSkillGridController()
	{
	}

	[Token(Token = "0x6011389")]
	[Address(RVA = "0x2C49BF8", Offset = "0x2C49BF8", VA = "0x2C49BF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601138A")]
	[Address(RVA = "0x2C49CA0", Offset = "0x2C49CA0", VA = "0x2C49CA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601138B")]
	[Address(RVA = "0x2C49ECC", Offset = "0x2C49ECC", VA = "0x2C49ECC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601138C")]
	[Address(RVA = "0x2C4A000", Offset = "0x2C4A000", VA = "0x2C4A000", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601138D")]
	[Address(RVA = "0x2C4A210", Offset = "0x2C4A210", VA = "0x2C4A210")]
	public void SetSelectedSkillInfo(List<PetSkillConfigInfo> dataShowList)
	{
	}

	[Token(Token = "0x601138E")]
	[Address(RVA = "0x2C4A3B8", Offset = "0x2C4A3B8", VA = "0x2C4A3B8")]
	private void ShowSkillList()
	{
	}

	[Token(Token = "0x601138F")]
	[Address(RVA = "0x2C4A69C", Offset = "0x2C4A69C", VA = "0x2C4A69C")]
	private void ShowSelectSkillList(object[] param)
	{
	}

	[Token(Token = "0x6011390")]
	[Address(RVA = "0x2C4A85C", Offset = "0x2C4A85C", VA = "0x2C4A85C")]
	public void ShowCurrentSelectedSkill(PetSkillConfigInfo data)
	{
	}

	[Token(Token = "0x6011391")]
	[Address(RVA = "0x2C4AA68", Offset = "0x2C4AA68", VA = "0x2C4AA68")]
	public void OnClickMask()
	{
	}

	[Token(Token = "0x6011392")]
	[Address(RVA = "0x2C4AC5C", Offset = "0x2C4AC5C", VA = "0x2C4AC5C")]
	public void ShowNoItemTips(bool isUnlock)
	{
	}

	[Token(Token = "0x6011393")]
	[Address(RVA = "0x2C4B198", Offset = "0x2C4B198", VA = "0x2C4B198", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011394")]
	[Address(RVA = "0x2C4B290", Offset = "0x2C4B290", VA = "0x2C4B290", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011395")]
	[Address(RVA = "0x2C4B30C", Offset = "0x2C4B30C", VA = "0x2C4B30C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011396")]
	[Address(RVA = "0x2C4B314", Offset = "0x2C4B314", VA = "0x2C4B314")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011397")]
	[Address(RVA = "0x2C4B31C", Offset = "0x2C4B31C", VA = "0x2C4B31C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
