using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AAA")]
public class UIProfileTagSmallController : UIBaseController
{
	[Token(Token = "0x401065D")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileSmallTagView m_View;

	[Token(Token = "0x401065E")]
	[FieldOffset(Offset = "0x2C")]
	private PlayerTagDataBase m_Data;

	[Token(Token = "0x401065F")]
	[FieldOffset(Offset = "0x30")]
	private ProfileTagType m_Type;

	[Token(Token = "0x4010660")]
	[FieldOffset(Offset = "0x34")]
	private int level;

	[Token(Token = "0x4010661")]
	[FieldOffset(Offset = "0x38")]
	private int m_PreviewNum;

	[Token(Token = "0x4010662")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_DisableClick;

	[Token(Token = "0x4010663")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_CacheEffect;

	[Token(Token = "0x4010664")]
	[FieldOffset(Offset = "0x44")]
	private readonly Vector2 heroicEffectPos;

	[Token(Token = "0x4010665")]
	[FieldOffset(Offset = "0x4C")]
	private readonly Vector2 heroicEffectScale;

	[Token(Token = "0x601173C")]
	[Address(RVA = "0x1AB6724", Offset = "0x1AB6724", VA = "0x1AB6724")]
	public UIProfileTagSmallController()
	{
	}

	[Token(Token = "0x601173D")]
	[Address(RVA = "0x1AB687C", Offset = "0x1AB687C", VA = "0x1AB687C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601173E")]
	[Address(RVA = "0x1AB6920", Offset = "0x1AB6920", VA = "0x1AB6920", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601173F")]
	[Address(RVA = "0x1AB6C70", Offset = "0x1AB6C70", VA = "0x1AB6C70")]
	public void InitOnLoading()
	{
	}

	[Token(Token = "0x6011740")]
	[Address(RVA = "0x1AB6CDC", Offset = "0x1AB6CDC", VA = "0x1AB6CDC")]
	public void DisableClick()
	{
	}

	[Token(Token = "0x6011741")]
	[Address(RVA = "0x1AB6D38", Offset = "0x1AB6D38", VA = "0x1AB6D38")]
	public void EnableClick()
	{
	}

	[Token(Token = "0x6011742")]
	[Address(RVA = "0x1AB6D94", Offset = "0x1AB6D94", VA = "0x1AB6D94")]
	public void DisableHover()
	{
	}

	[Token(Token = "0x6011743")]
	[Address(RVA = "0x1AB6E7C", Offset = "0x1AB6E7C", VA = "0x1AB6E7C")]
	private void PlayAnim()
	{
	}

	[Token(Token = "0x6011744")]
	[Address(RVA = "0x1AB702C", Offset = "0x1AB702C", VA = "0x1AB702C")]
	public void SetViewData(PlayerTagDataBase data, ProfileTagType type, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011745")]
	[Address(RVA = "0x1AB714C", Offset = "0x1AB714C", VA = "0x1AB714C")]
	private void RefreshSocialView(PlayerTagDataBase data, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011746")]
	[Address(RVA = "0x1AB73B4", Offset = "0x1AB73B4", VA = "0x1AB73B4")]
	private void RefreshBattleView(PlayerTagDataBase data, bool refreshbg = true)
	{
	}

	[Token(Token = "0x6011747")]
	[Address(RVA = "0x1AB7D94", Offset = "0x1AB7D94", VA = "0x1AB7D94")]
	public void SetSelectedState(bool selected)
	{
	}

	[Token(Token = "0x6011748")]
	[Address(RVA = "0x1AB7E2C", Offset = "0x1AB7E2C", VA = "0x1AB7E2C")]
	public void SetEquipedState(bool equiped)
	{
	}

	[Token(Token = "0x6011749")]
	[Address(RVA = "0x1AB7EE4", Offset = "0x1AB7EE4", VA = "0x1AB7EE4")]
	private void OnSmallTagClick()
	{
	}

	[Token(Token = "0x601174A")]
	[Address(RVA = "0x1AB8164", Offset = "0x1AB8164", VA = "0x1AB8164")]
	public void DisableBtn()
	{
	}

	[Token(Token = "0x601174B")]
	[Address(RVA = "0x1AB81FC", Offset = "0x1AB81FC", VA = "0x1AB81FC")]
	public void EnableBtn()
	{
	}

	[Token(Token = "0x601174C")]
	[Address(RVA = "0x1AB8294", Offset = "0x1AB8294", VA = "0x1AB8294")]
	public void EnableHover()
	{
	}

	[Token(Token = "0x601174D")]
	[Address(RVA = "0x1AB8344", Offset = "0x1AB8344", VA = "0x1AB8344")]
	public void SetPreviewState(int index)
	{
	}

	[Token(Token = "0x601174E")]
	[Address(RVA = "0x1AB8638", Offset = "0x1AB8638", VA = "0x1AB8638")]
	private void OnHover(bool flag)
	{
	}

	[Token(Token = "0x601174F")]
	[Address(RVA = "0x1AB88F8", Offset = "0x1AB88F8", VA = "0x1AB88F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
