using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200279D")]
internal class UIHudKillDetailController : UIBaseController
{
	[Token(Token = "0x400F493")]
	[FieldOffset(Offset = "0x28")]
	private UIHudKillDetailView m_View;

	[Token(Token = "0x400F494")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x400F495")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsKnockDownPage;

	[Token(Token = "0x400F496")]
	[FieldOffset(Offset = "0x34")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x600F424")]
	[Address(RVA = "0x20B57D4", Offset = "0x20B57D4", VA = "0x20B57D4")]
	public UIHudKillDetailController()
	{
	}

	[Token(Token = "0x600F425")]
	[Address(RVA = "0x20B5858", Offset = "0x20B5858", VA = "0x20B5858")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F426")]
	[Address(RVA = "0x20B58FC", Offset = "0x20B58FC", VA = "0x20B58FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F427")]
	[Address(RVA = "0x20B5CA8", Offset = "0x20B5CA8", VA = "0x20B5CA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F428")]
	[Address(RVA = "0x20B5D0C", Offset = "0x20B5D0C", VA = "0x20B5D0C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F429")]
	[Address(RVA = "0x20B6224", Offset = "0x20B6224", VA = "0x20B6224")]
	private void RefreshKillDetail(int weaponDataId, string killKey, string titleKey, BaseProfileInfo profileInfo, int realDamage, bool isHeadshot)
	{
	}

	[Token(Token = "0x600F42A")]
	[Address(RVA = "0x20B5FAC", Offset = "0x20B5FAC", VA = "0x20B5FAC")]
	private bool RefreshKnockDownPage()
	{
		return default(bool);
	}

	[Token(Token = "0x600F42B")]
	[Address(RVA = "0x20B60E8", Offset = "0x20B60E8", VA = "0x20B60E8")]
	private bool RefreshDeadPage()
	{
		return default(bool);
	}

	[Token(Token = "0x600F42C")]
	[Address(RVA = "0x20B7204", Offset = "0x20B7204", VA = "0x20B7204")]
	private void OnBtnChangePageClick()
	{
	}

	[Token(Token = "0x600F42D")]
	[Address(RVA = "0x20B7284", Offset = "0x20B7284", VA = "0x20B7284")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600F42E")]
	[Address(RVA = "0x20B72BC", Offset = "0x20B72BC", VA = "0x20B72BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F42F")]
	[Address(RVA = "0x20B72C4", Offset = "0x20B72C4", VA = "0x20B72C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F430")]
	[Address(RVA = "0x20B72CC", Offset = "0x20B72CC", VA = "0x20B72CC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
