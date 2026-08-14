using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AA9")]
public class UIProfileTagController : UIBaseController
{
	[Token(Token = "0x4010653")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileTagView m_View;

	[Token(Token = "0x4010654")]
	[FieldOffset(Offset = "0x2C")]
	private PlayerTagDataBase m_Data;

	[Token(Token = "0x4010655")]
	[FieldOffset(Offset = "0x30")]
	private ProfileTagType m_Type;

	[Token(Token = "0x4010656")]
	[FieldOffset(Offset = "0x34")]
	private int level;

	[Token(Token = "0x4010657")]
	[FieldOffset(Offset = "0x0")]
	public static ResourceID VfxLevel3;

	[Token(Token = "0x4010658")]
	[FieldOffset(Offset = "0x4")]
	public static ResourceID VfxLevel4;

	[Token(Token = "0x4010659")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_CacheEffect;

	[Token(Token = "0x401065A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Color colorlock;

	[Token(Token = "0x401065B")]
	[FieldOffset(Offset = "0x3C")]
	private readonly Vector2 heroicEffectPos;

	[Token(Token = "0x401065C")]
	[FieldOffset(Offset = "0x44")]
	private readonly Vector2 heroicEffectScale;

	[Token(Token = "0x6011730")]
	[Address(RVA = "0x1AB4DD8", Offset = "0x1AB4DD8", VA = "0x1AB4DD8")]
	public UIProfileTagController()
	{
	}

	[Token(Token = "0x6011731")]
	[Address(RVA = "0x1AB4F30", Offset = "0x1AB4F30", VA = "0x1AB4F30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011732")]
	[Address(RVA = "0x1AB4FD4", Offset = "0x1AB4FD4", VA = "0x1AB4FD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011733")]
	[Address(RVA = "0x1AB5250", Offset = "0x1AB5250", VA = "0x1AB5250")]
	public void SetViewData(PlayerTagDataBase data, ProfileTagType type, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011734")]
	[Address(RVA = "0x1AB5310", Offset = "0x1AB5310", VA = "0x1AB5310")]
	private void RefreshSocialView(PlayerTagDataBase data, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011735")]
	[Address(RVA = "0x1AB5584", Offset = "0x1AB5584", VA = "0x1AB5584")]
	private void RefreshBattleView(PlayerTagDataBase data, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011736")]
	[Address(RVA = "0x1AB61E0", Offset = "0x1AB61E0", VA = "0x1AB61E0")]
	public void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x6011737")]
	[Address(RVA = "0x1AB6128", Offset = "0x1AB6128", VA = "0x1AB6128")]
	public void SetEquipedState(bool equiped)
	{
	}

	[Token(Token = "0x6011738")]
	[Address(RVA = "0x1AB6278", Offset = "0x1AB6278", VA = "0x1AB6278")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x6011739")]
	[Address(RVA = "0x1AB6428", Offset = "0x1AB6428", VA = "0x1AB6428")]
	public void OnTagClick()
	{
	}

	[Token(Token = "0x601173B")]
	[Address(RVA = "0x1AB671C", Offset = "0x1AB671C", VA = "0x1AB671C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
