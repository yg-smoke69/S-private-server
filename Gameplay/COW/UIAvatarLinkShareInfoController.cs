using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024B5")]
public class UIAvatarLinkShareInfoController : UIBaseController
{
	[Token(Token = "0x400E39F")]
	[FieldOffset(Offset = "0x28")]
	private UIAvatarLinkShareInfoView m_View;

	[Token(Token = "0x400E3A0")]
	[FieldOffset(Offset = "0x2C")]
	private AvatarSkillData m_SkillData;

	[Token(Token = "0x400E3A1")]
	[FieldOffset(Offset = "0x30")]
	private UIAvatarSkillSlotController m_AvatarSkillSlotController;

	[Token(Token = "0x400E3A2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color ActiveSkillColor;

	[Token(Token = "0x400E3A3")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color PassiveSkillColor;

	[Token(Token = "0x400E3A4")]
	private const string ACTIVE_SKILL_TYPE_KEY = "T_22_A_SKILL_A";

	[Token(Token = "0x400E3A5")]
	private const string PASSIVE_SKILL_TYPE_KEY = "T_22_A_SKILL_P";

	[Token(Token = "0x400E3A6")]
	[FieldOffset(Offset = "0x34")]
	private bool m_AvatarLinkFlag;

	[Token(Token = "0x400E3A7")]
	[FieldOffset(Offset = "0x38")]
	private string titleColor;

	[Token(Token = "0x600D287")]
	[Address(RVA = "0x2A99784", Offset = "0x2A99784", VA = "0x2A99784")]
	public UIAvatarLinkShareInfoController()
	{
	}

	[Token(Token = "0x600D288")]
	[Address(RVA = "0x2A9981C", Offset = "0x2A9981C", VA = "0x2A9981C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D289")]
	[Address(RVA = "0x2A998C4", Offset = "0x2A998C4", VA = "0x2A998C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D28A")]
	[Address(RVA = "0x2A99980", Offset = "0x2A99980", VA = "0x2A99980", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D28B")]
	[Address(RVA = "0x2A999E4", Offset = "0x2A999E4", VA = "0x2A999E4")]
	public void SetAvatarLinkContentShareBefore(CSSharedItemData data, ItemUtil.ItemShareType type)
	{
	}

	[Token(Token = "0x600D28D")]
	[Address(RVA = "0x2A9A7C0", Offset = "0x2A9A7C0", VA = "0x2A9A7C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D28E")]
	[Address(RVA = "0x2A9A7C8", Offset = "0x2A9A7C8", VA = "0x2A9A7C8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
